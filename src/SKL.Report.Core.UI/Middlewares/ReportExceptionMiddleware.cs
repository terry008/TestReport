using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace SKL.Report.Core.UI.Middlewares
{
    //全局异常处理中间件
    public class ReportExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ReportExceptionMiddleware> logger;
        private readonly IHostingEnvironment env;

        public ReportExceptionMiddleware(RequestDelegate next, ILogger<ReportExceptionMiddleware> logger, IHostingEnvironment env)
        {
            this._next = next;
            this.logger = logger;
            this.env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                void ReadException(Exception exception)
                {
                    error += string.Format("{0}|{1}|{2}", exception.Message, exception.StackTrace, exception.InnerException);
                    if (exception.InnerException != null)
                        ReadException(exception.InnerException);
                }
                //读取异常信息
                ReadException(ex);
                //日志记录异常信息
                logger.LogError(error);

                //返回友好提示
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "text/json;charset=utf-8;";

                string result = string.Empty;
                if (env.IsDevelopment())
                    result = JsonConvert.SerializeObject(new { code = 500, msg = error });
                else
                    result = JsonConvert.SerializeObject(new { code = 500, msg = "抱歉出错了！" });
                await context.Response.WriteAsync(result);
            }
        }
    }
}

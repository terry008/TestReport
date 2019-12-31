using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SKL.Report.Core.Models;
using SKL.Report.Core.UI.Filters;
using SKL.Report.Core.UI.Middlewares;
using SKL.Report.Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoMapper;
using SKL.Report.Core.UI.AppCode;

namespace SKL.Report.Core.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //注册映射服务
            services.AddAutoMapper(typeof(ReportMapperProfile));

            services.AddDbContext<ReportDBContext>(o => o.UseMySQL(Configuration.GetConnectionString("skl_report")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //管理员登录采用默认票据
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
            {
                o.LoginPath = new PathString("/reportadmin/Home/Login");
                o.ExpireTimeSpan = TimeSpan.FromHours(1);//1小时不超过，就超时
            })
            //学员前台登录，采用自定义票据
            .AddCookie(StudentAuthorizeAttribute.StudentAuthenticationScheme, o =>
            {
                o.LoginPath = new PathString("/Error");
                o.ExpireTimeSpan = TimeSpan.FromMinutes(30);//30分钟不操作，过期
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //注册所有仓储服务
            RegisterServices(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        //注册所有仓储服务
        void RegisterServices(IServiceCollection services)
        {
            Assembly IRepository = Assembly.Load(new AssemblyName("SKL.Report.Core.Services"));
            //所有接口
            var ITypes = IRepository.GetTypes().Where(c => c.Namespace == "SKL.Report.Core.Services.Interface" && c.GetTypeInfo().IsInterface && typeof(IDependency).IsAssignableFrom(c)).ToList();
            //所有实现类
            var Types = IRepository.GetTypes().Where(c => c.Namespace == "SKL.Report.Core.Services.Repository").ToList();
            //遍历注册
            Types.ForEach(type =>
            {
                foreach (var itype in ITypes)
                {
                    if (itype.IsAssignableFrom(type))
                    {
                        //生命周期，有待商酌，到底是用transit还是scoped
                        //services.Add(new ServiceDescriptor(serviceType: itype, implementationType: type, lifetime: ServiceLifetime.Transient));
                        services.AddTransient(itype, type);
                    }
                }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            // else
            // {
            // app.UseExceptionHandler("/Home/Error");
            // // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            // app.UseHsts();
            // }
            //认证
            app.UseAuthentication();

            //全局加入异常处理中间件
            app.UseMiddleware<ReportExceptionMiddleware>();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                //注册管理后台路由地址
                routes.MapRoute(
                    name: "admin",
                    template: "{area:exists}/{controller=Home}/{action=index}/{id?}"
                );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

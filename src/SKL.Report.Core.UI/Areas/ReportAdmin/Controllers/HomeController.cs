using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;
using SKL.Report.Core.Services.Interface;
using Newtonsoft.Json;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Controllers
{
    [Area("reportadmin")]
    public class HomeController : Controller
    {
        private readonly IReportRepository reportRepository;

        public HomeController(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        public IActionResult Test(int id)
        {
            var bb = reportRepository.GetById(id);
            return Content(JsonConvert.SerializeObject(bb));
        }

        //登录界面
        public IActionResult Login() => View();

        //登录提交
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginModel user)
        {
            if (user.UserName == "terry" && user.Password == "123456")
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Country, "翠竹分校"));
                identity.AddClaim(new Claim(ClaimTypes.Sid, "122"));
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                //授权完成，跳转到考试管理页
                return RedirectToAction("List", "Test");
            }
            return View(user);
        }

        //注销
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

    }
}

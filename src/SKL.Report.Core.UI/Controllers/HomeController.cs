using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.UI.Filters;
using SKL.Report.Core.UI.Models;

namespace SKL.Report.Core.UI.Controllers
{
    //测评报告前台页面
    public class HomeController : Controller
    {

        //报表查询页面
        [Route("Login/{tid}")]
        public IActionResult Login(string tid)
        {
            return View();
        }

        [HttpPost]
        [Route("Login/{tid}")]
        public async Task<IActionResult> Login(StudentLoginModel student, string tid)
        {
            if (ModelState.IsValid)
            {
                if (student.StuName == "terry" && student.Phone == "13412341234")
                {
                    var identity = new ClaimsIdentity(StudentAuthorizeAttribute.StudentAuthenticationScheme);
                    identity.AddClaim(new Claim(ClaimTypes.Name, student.StuName));
                    identity.AddClaim(new Claim(ClaimTypes.MobilePhone, student.Phone));
                    await HttpContext.SignInAsync(StudentAuthorizeAttribute.StudentAuthenticationScheme, new ClaimsPrincipal(identity));
                    return RedirectToAction("ReportDetail", new { tid, rptid = Guid.NewGuid().ToString("N") });
                }
            }
            return View(student);
        }

        //报告详情
        [StudentAuthorizeAttribute]
        [Route("Report/{tid}/{rptid}")]
        public IActionResult ReportDetail(string tid, string rptid)
        {
            ReportViewModel model = NewMethod();

            return View(model);
        }

        //查询超时页
        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





        private ReportViewModel NewMethod()
        {
            ReportViewModel model = new ReportViewModel
            {
                Title = "test oh my lady",
                StuName = "terry",
                TotalScores = 60,
                ShowSort = true,
                MySort = 10,
                OverRate = 30,
                ShowSubjectSort = true,
                SubjectSummary = new List<ReportSubjectSummary>(),
                ShowTestRemark = true,
                TestRemark = "testremark",
                ShowAnalysis = true,
                Analysis = "fenxi",
                AnalysisTitle = "fenxi title",
                ShowAwards = true,
                Awards = "huojiang ",
                AwardsTitle = "huojiang title",
                Subjects = new List<SubjectDetail>(),
                TotalRemark = "本次考试整体难度适中，从你的得分来看，你的基础知识掌握较扎实，词汇、语法的运用能力及阅读理解能力都有比较大的提升空间。后续的提升方向是构建自己的语法体系，建立错题本，并利用错题本对自己的薄弱模块进行专项训练。同时加强听力输入和课外拓展阅读的训练（如分级读物等），让自己的进步速度更快些！"
            };

            model.SubjectSummary = new List<ReportSubjectSummary>{
                new ReportSubjectSummary{SubjectName="数学",TotalScores=30,AvgScores=23.5m,MyScores=28.7m,MySort=12},
                new ReportSubjectSummary{SubjectName="语文",TotalScores=33,AvgScores=13.5m,MyScores=18.7m,MySort=11},
                new ReportSubjectSummary{SubjectName="英语",TotalScores=37,AvgScores=15.5m,MyScores=20.7m,MySort=8},
            };

            model.Subjects = new List<SubjectDetail>{
new SubjectDetail{
    SubjectName="数学",
    MySubjectScores=23.5m,
    SubjectTotalScores=30m,
    SubjectPy="基础综合知识模块是你非常薄弱的环节，本次考试难度适中。五年级这个阶段一定要大力加强基础知识的训练，字音、字形、成语、病句、句式转换排序等小学阶段的知识，需要再加强。该模块各类考试中都可能考到，是很重要的专题。如果目前没有在学习文史常识，建议五年级关键阶段，一定要抽时间学习，这对你将来的学习非常重要。加油，知足知不足，提升自己。随着高考方向的改革及部编版教材的改革，语文在各个领域都会得到不同程度的重视，我们自己要先重视起来，为以后的学习打下坚实的基础！~",
    Modules=new List<ModulesDetail>{
        new ModulesDetail{ModuleName="计算",ModuleTotalScores=12.3m,ModuleAvgScores=10.23m,ModulesPy="还不错哦哦",MyModuleScores=32.68m,MyModuleSort=12,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈哈哈哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈1"},
        }},

        new ModulesDetail{ModuleName="应用题",ModuleTotalScores=45.6m,ModuleAvgScores=3.68m,ModulesPy="还不错哦哦",MyModuleScores=19.68m,MyModuleSort=23,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈1"},
            new TimuDetail{TMNo="3",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈2"},
            new TimuDetail{TMNo="6",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈5"},
        }},

        new ModulesDetail{ModuleName="主观题",ModuleTotalScores=78.9m,ModuleAvgScores=23.65m,ModulesPy="还不错哦哦",MyModuleScores=10.3m,MyModuleSort=34,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈1"},
            new TimuDetail{TMNo="3",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈2"},
            new TimuDetail{TMNo="4",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈3"},
        }},
    }},

    new SubjectDetail{
    SubjectName="语文",
    MySubjectScores=32.5m,
    SubjectTotalScores=30m,
    SubjectPy="古诗词积累模块是你非常薄弱的环节，本次考试难度适中。五年级这个阶段一定要大力加强古诗词积累和背诵的训练。该板块在各类考试中都会考到，是很重要的专题。本次考察的知识点很多都属于校内学习的内容，希望你能认真复习学习过的古诗词，深刻理解古诗词的含义，然后再做到活学活用。加油！~",
    Modules=new List<ModulesDetail>{
        new ModulesDetail{ModuleName="填空题",ModuleTotalScores=23.65m,ModuleAvgScores=32.12m,ModulesPy="阅读理解模块，你的得分情况属于中等水平。本次考试的阅读理解难度一般，重点考察对记叙文的整体把握以及理解。对领会文章中心思想，概括主要事件、联系上下文理解重要词语等方面做逐题考察。该模块作为语文学习的重点版块，在各大类考试中必考，并且在高年级学习阶段比重和分值会逐渐变大。以你目前的得分情况，需要逐渐形成规范性答题的意识，并且在答题完整性上下功夫。平时要注意精读，对于文章的把握要更加细致，为今后的学习打下坚实的基础!",MyModuleScores=10.3m,MyModuleSort=33,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈"},
            new TimuDetail{TMNo="6",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈5"},
        }},

        new ModulesDetail{ModuleName="选择题",ModuleTotalScores=45.68m,ModuleAvgScores=12.34m,ModulesPy="还不错哦哦",MyModuleScores=9.63m,MyModuleSort=5,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈1"},
            new TimuDetail{TMNo="5",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈4"},
            new TimuDetail{TMNo="6",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈5"},
        }},

        new ModulesDetail{ModuleName="作文",ModuleTotalScores=15.3m,ModuleAvgScores=65.23m,ModulesPy=" 你好！本次考试70％是课内知识，30％是课外知识，整体难度适中，从你目前的分数来看，第一部分:对于校内的知识点掌握的不够扎实，字音、字形、词语、病句、句式转换、排序等基础知识需要加强。校内每课的生字词，单元的日积月累以及古诗要重点复习，勤于动笔。课内巩固推荐《黄冈小状元》《北大绿卡》《期末冲刺一百分》等资料；第二部分：诗词名句，小学生必背古诗在多背多默写的基础上加强理解，务必要能活学活用；第三部分：阅读理解为现代文，现代文的各大体裁、阅读技巧要多积累和练习，推荐《小学生阅读80篇》《窦桂梅教你阅读》《黑马阅读》等等；第四部分：文史知识，从你的得分来看文学历史常识类知识的积累很少，推荐《中华上下五千年》（青少版）等课外书。",MyModuleScores=10.3m,MyModuleSort=33,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="4",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈3"},
            new TimuDetail{TMNo="5",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈哈哈哈哈4"},
            new TimuDetail{TMNo="6",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈哈哈5"},
        }},
    }},

    new SubjectDetail{
    SubjectName="英语",
    MySubjectScores=23.5m,
    SubjectTotalScores=30m,
    SubjectPy="good~",
    Modules=new List<ModulesDetail>{
        new ModulesDetail{ModuleName="口语",ModuleTotalScores=35m,ModuleAvgScores=10.32m,ModulesPy="还不错哦哦",MyModuleScores=33.33m,MyModuleSort=1,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈1"},
            new TimuDetail{TMNo="3",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈2"},
            new TimuDetail{TMNo="4",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈3"},
            new TimuDetail{TMNo="5",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈4"},
        }},

        new ModulesDetail{ModuleName="听力",ModuleTotalScores=12.34m,ModuleAvgScores=23.62m,ModulesPy="还不错哦哦",MyModuleScores=15.3m,MyModuleSort=2,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈1"},
            new TimuDetail{TMNo="5",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈4"},
            new TimuDetail{TMNo="6",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈5"},
        }},

        new ModulesDetail{ModuleName="选择",ModuleTotalScores=63.23m,ModuleAvgScores=60.12m,ModulesPy="还不错哦哦",MyModuleScores=32.3m,MyModuleSort=3,
        Timus=new List<TimuDetail>{
            new TimuDetail{TMNo="1",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈"},
            new TimuDetail{TMNo="2",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈1"},
            new TimuDetail{TMNo="3",Scores=3,Avgs=3,MyScores=2.5m,TmPy="哈哈2"},
        }},
    }}

            };
            return model;
        }

    }
}

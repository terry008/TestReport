using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;
using SKL.Report.Core.Models;
using SKL.Report.Core.Services.Interface;
using System.Linq;
using AutoMapper;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Controllers
{
    [Area("reportadmin"), Authorize]
    public class TestController : Controller
    {
        private readonly IReportRepository reportRepository;
        private readonly IMapper mapper;
        public TestController(IReportRepository reportRepository, IMapper mapper)
        {
            this.reportRepository = reportRepository;
            this.mapper = mapper;
        }

        public IActionResult List() => View();

        //查询当页内容
        public IActionResult ListContent(string testName, int pageIndex)
        {
            int pageSize = 10;
            pageIndex--;
            var data = reportRepository.GetPageData(testName, pageIndex, pageSize);
            return PartialView("ListContent", data);
        }

        //查询总数
        public IActionResult ListRecordCount(string testName)
        {
            int recordCount = reportRepository.GetPageRecordCount(testName);
            return Content(recordCount.ToString());
        }

        //编辑
        public IActionResult Edit(int? id)
        {
            ReportEditModel model = new ReportEditModel();
            if (id != null)
            {
                var report = reportRepository.GetById(id.Value);
                model = mapper.Map<ReportEditModel>(report);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ReportEditModel model)
        {
            var report = mapper.Map<rpt_info>(model);
            if (model.ID > 0)
            {
                reportRepository.Update(report);
            }
            else
            {

                report.TestCount = 0;
                report.SearchCount = 0;
                reportRepository.Add(report);
            }
            reportRepository.SaveChanges();
            return View(model);
        }

    }
}

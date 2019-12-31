using System;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.Models;
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;
using SKL.Report.Core.Services.Interface;
using Microsoft.AspNetCore.Authorization;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Controllers
{
    [Area("reportadmin"), Authorize]
    public class PingyuController : Controller
    {
        private readonly ICommentRepository commentRepository;

        public PingyuController(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        //评语设置
        public IActionResult Edit(int rptid)
        {
            ViewData["rptid"] = rptid;
            return View();
        }

        //获取模块评语
        [HttpPost]
        public IActionResult GetCommentList(int rptid, int mid)
        {
            var data = commentRepository.GetCommentByModuleID(rptid, mid);
            return Json(data);
        }

        [HttpPost]
        public IActionResult AddPy(rpt_comment comment)
        {
            if (comment.ID > 0)
            {
                commentRepository.Update(comment, "");
            }
            else
            {
                commentRepository.Add(comment);
            }
            commentRepository.SaveChanges();
            return Ok();
        }

    }
}

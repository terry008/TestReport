using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.Services.Interface;
using SKL.Report.Core.Models.DTOModels;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Controllers
{
    [Area("reportadmin"), Authorize]
    public class ScoresController : Controller
    {
        private readonly IScoresRepository scoresRepository;

        public ScoresController(IScoresRepository scoresRepository)
        {
            this.scoresRepository = scoresRepository;
        }
        public IActionResult List(int id)
        {

            return View();
        }

        public IActionResult Edit()
        {

            return View();
        }

        public IActionResult Test()
        {
            return Ok("baga");
        }

        [HttpPost]
        public IActionResult ScoresList(int rptid, int userid)
        {
            var b = scoresRepository.GetUserScores(rptid, userid);
            return Json(b);
        }
    }
}

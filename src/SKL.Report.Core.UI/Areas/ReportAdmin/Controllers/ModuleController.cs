using System;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.Models;
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;
using SKL.Report.Core.Services.Interface;
using System.Linq;
using System.Collections.Generic;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Controllers
{
    //模块管理
    [Area("reportadmin"), Authorize]
    public class ModuleController : Controller
    {
        private readonly IModuleRepository moduleRepository;
        private readonly IReportRepository reportRepository;
        private readonly IScoresRepository scoresRepository;
        private readonly IMapper mapper;

        public ModuleController(
            IModuleRepository moduleRepository,
            IReportRepository reportRepository,
            IScoresRepository scoresRepository,
            IMapper mapper)
        {
            this.moduleRepository = moduleRepository;
            this.reportRepository = reportRepository;
            this.scoresRepository = scoresRepository;
            this.mapper = mapper;
        }

        public IActionResult Edit(int rptid)
        {
            rpt_modules module = new rpt_modules();
            module.ReportID = rptid;
            return View(module);
        }

        [HttpPost]
        public IActionResult Edit(rpt_modules modules)
        {
            if (modules.ID > 0)
            {
                moduleRepository.Update(modules, "ModuleName", "FatherModuleID", "ModuleTotalScores", "ModuleAvgScores", "ModuleSort");
            }
            else
            {
                moduleRepository.Add(modules);
            }
            moduleRepository.SaveChanges();
            return View(modules);
        }

        [HttpPost]
        public IActionResult GetModule(int id)
        {
            var model = moduleRepository.GetById(id);
            return Json(model);
        }

        //获取学员此考试的得分，包含所有模块
        [HttpPost]
        public IActionResult GetModuleTable(int rptid, int userid)
        {
            
            //所有模块
            var report = moduleRepository.GetModulesByReportID(rptid);
            //所有父id
            var allFatherIDs = report.Select(c => c.FatherModuleID).Distinct();
            //所有终点id
            var finalNodes = report.Where(c => !allFatherIDs.Contains(c.ID));
            //递归获取节点的组合名称
            string GetFatherName(rpt_modules m)
            {
                if (m.FatherModuleID > 0)
                {
                    var father = report.FirstOrDefault(c => c.ID == m.FatherModuleID);
                    return GetFatherName(father) + " - " + m.ModuleName;
                }
                else
                {
                    return m.ModuleName;
                }
            }
            List<Tuple<string, int, decimal>> scores = new List<Tuple<string, int, decimal>>();
            //用户模块的所有得分
            var b = scoresRepository.GetUserScoresByRpt(rptid, userid);
            foreach (var item in finalNodes)
            {
                var md = b.FirstOrDefault(c => c.ModuleID == item.ID);
                decimal defen = md == null ? 0 : md.Scores;
                scores.Add(new Tuple<string, int, decimal>(GetFatherName(item), item.ID, defen));
            }
            return Json(scores.OrderBy(c => c.Item1));
        }

        //获取模块树JSON
        [HttpPost]
        public IActionResult GetModuleTree(int rptid)
        {
            List<ModuleTreeModel> mtList = new List<ModuleTreeModel>();
            var report = reportRepository.GetById(rptid);
            ModuleTreeModel rootNode = new ModuleTreeModel();
            rootNode.id = 0;
            rootNode.title = report.ReportName;
            rootNode.children = new List<ModuleTreeModel>();
            mtList.Add(rootNode);

            var all = moduleRepository.GetModulesByReportID(rptid);
            void BuildNode(List<ModuleTreeModel> mt, int fatherid = 0)
            {
                var nodes = all.Where(c => c.FatherModuleID == fatherid);
                foreach (var item in nodes)
                {
                    var mtm = new ModuleTreeModel();
                    mtm.id = item.ID;
                    mtm.title = string.Format("[{0}]{1}({2}分)", item.ID, item.ModuleName, item.ModuleTotalScores);
                    if (all.Any(c => c.FatherModuleID == item.ID))
                    {
                        mtm.children = new List<ModuleTreeModel>();
                        BuildNode(mtm.children, item.ID);
                    }
                    mt.Add(mtm);
                }
            }
            BuildNode(rootNode.children);
            return Json(mtList);
        }

    }
}

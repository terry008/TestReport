using System;
using System.Collections.Generic;
using SKL.Report.Core.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace SKL.Report.Core.UI.ViewComponents
{
    public class SubjectTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<ModulesDetail> modules, bool showSort)
        {
            ViewData["showSort"] = showSort;
            return View("SubjectTable", modules);
        }
    }
}

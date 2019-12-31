using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SKL.Report.Core.UI.Models;

namespace SKL.Report.Core.UI.ViewComponents
{
    public class ChartViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(IEnumerable<ModulesDetail> modules)
        {

            return View("Chart", modules);
        }
    }
}

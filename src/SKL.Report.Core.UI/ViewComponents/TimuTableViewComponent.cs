using System;
using SKL.Report.Core.UI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SKL.Report.Core.UI.ViewComponents
{
    public class TimuTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<TimuDetail> timus)
        {

            return View("TimuTable", timus);
        }
    }
}

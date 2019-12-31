using System;
using System.Collections.Generic;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Models
{
    //模块layui-tree
    public class ModuleTreeModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool spread => true;
        public List<ModuleTreeModel> children { get; set; }
    }
}

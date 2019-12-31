using System;

namespace SKL.Report.Core.UI.Areas.ReportAdmin.Models
{
    //模块编辑视图
    public class ModuleEditView
    {
        public string ModuleName { get; set; }
        public string FatherModule { get; set; }
        public decimal TotalScores { get; set; }
        public decimal AvgScores { get; set; }
        public int Sort { get; set; }
    }
}

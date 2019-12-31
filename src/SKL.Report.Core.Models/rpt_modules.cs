using System;

namespace SKL.Report.Core.Models
{
    //报告模块信息
    public class rpt_modules : BaseEntity
    {
        //报告ID
        public int ReportID { get; set; }
        //上级模块ID
        public int FatherModuleID { get; set; }
        //模块名称
        public string ModuleName { get; set; }
        //模块总分
        public decimal ModuleTotalScores { get; set; }
        //模块平均分
        public decimal ModuleAvgScores { get; set; }
        //模块排序
        public int ModuleSort { get; set; }
    }
}

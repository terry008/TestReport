using System;

namespace SKL.Report.Core.Models
{
    //报告评语
    public class rpt_comment : BaseEntity
    {
        //报告ID
        public int ReportID { get; set; }
        //模块ID
        public int ModuleID { get; set; }
        //评语上限分数
        public decimal MaxScores { get; set; }
        //评语内容
        public string CommentContent { get; set; }
    }
}

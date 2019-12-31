using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKL.Report.Core.Models
{
    //用户得分
    public class rpt_userscores : BaseEntity
    {
        //用户ID
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual rpt_user User { get; set; }
        //报告ID
        public int ReportID { get; set; }
        [ForeignKey("ReportID")]
        public virtual rpt_info Report { get; set; }
        //模块ID
        public int ModuleID { get; set; }
        [ForeignKey("ModuleID")]
        public virtual rpt_modules Module { get; set; }
        //模块得分
        public decimal Scores { get; set; }
    }
}

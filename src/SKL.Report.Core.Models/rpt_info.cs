using System;

namespace SKL.Report.Core.Models
{
    //报告主体信息
    public class rpt_info : BaseEntity
    {
        public string ReportName { get; set; }
        public string ReportDesc { get; set; }
        //报告人数
        public int TestCount { get; set; }
        //查询次数
        public int SearchCount { get; set; }
        public DateTime SearchOpenStart { get; set; }
        public DateTime SearchOpenEnd { get; set; }

    }
}

using System;
using SKL.Report.Core.Models;
using System.Collections.Generic;

namespace SKL.Report.Core.Services.Interface
{
    public interface IReportRepository : IBaseRepository<rpt_info>, IDependency
    {
        //获取分页数据
        List<rpt_info> GetPageData(string reportName, int pageIndex, int pageSize);
        //获取查询总数
        int GetPageRecordCount(string reportName);
    }
}

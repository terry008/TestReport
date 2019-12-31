using System;
using SKL.Report.Core.Models;
using System.Collections.Generic;

namespace SKL.Report.Core.Services.Interface
{
    public interface IModuleRepository : IBaseRepository<rpt_modules>, IDependency
    {
        //通过报告id获取所有的模块
        List<rpt_modules> GetModulesByReportID(int rptid);
    }
}

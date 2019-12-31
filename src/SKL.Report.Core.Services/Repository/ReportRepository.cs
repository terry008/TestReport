using System;
using System.Collections.Generic;
using System.Linq;
using SKL.Report.Core.Models;
using SKL.Report.Core.Services.Interface;

namespace SKL.Report.Core.Services.Repository
{
    public class ReportRepository : BaseRepository<rpt_info>, IReportRepository
    {
        private readonly ReportDBContext dbcontext;
        public ReportRepository(ReportDBContext context) : base(context)
        {
            dbcontext = context;
        }
        public List<rpt_info> GetPageData(string reportName, int pageIndex, int pageSize)
        {
            var querys = dbcontext.rpt_Infos.AsQueryable();
            if (!string.IsNullOrEmpty(reportName))
                querys = querys.Where(c => c.ReportName.Contains(reportName));
            return querys.OrderByDescending(c => c.ID).Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }
        public int GetPageRecordCount(string reportName)
        {
            if (!string.IsNullOrEmpty(reportName))
                return dbcontext.rpt_Infos.Count(c => c.ReportName.Contains(reportName));
            return dbcontext.rpt_Infos.Count();
        }
    }
}

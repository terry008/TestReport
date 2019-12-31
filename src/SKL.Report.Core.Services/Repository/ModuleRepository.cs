using System;
using System.Collections.Generic;
using SKL.Report.Core.Models;
using SKL.Report.Core.Services.Interface;
using System.Linq;

namespace SKL.Report.Core.Services.Repository
{
    public class ModuleRepository : BaseRepository<rpt_modules>, IModuleRepository
    {
        private readonly ReportDBContext context;

        public ModuleRepository(ReportDBContext context) : base(context)
        {
            this.context = context;
        }

        public List<rpt_modules> GetModulesByReportID(int rptid)
        {
            return context.rpt_Modules.Where(c => c.ReportID == rptid).ToList();
        }
    }
}

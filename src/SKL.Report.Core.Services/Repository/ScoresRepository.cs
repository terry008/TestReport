using System;
using SKL.Report.Core.Services.Interface;
using SKL.Report.Core.Models;
using System.Collections.Generic;
using System.Linq;
using SKL.Report.Core.Models.DTOModels;
using Microsoft.EntityFrameworkCore;

namespace SKL.Report.Core.Services.Repository
{
    public class ScoresRepository : BaseRepository<rpt_userscores>, IScoresRepository
    {
        private readonly ReportDBContext context;

        public ScoresRepository(ReportDBContext context) : base(context)
        {
            this.context = context;
        }

        public List<UserScores> GetUserScores(int rptid, int userid)
        {
            var q = context.rpt_Userscores
                   .Include(r => r.Report)
                   .Include(m => m.Module)
                   .Include(u => u.User)
                   .Where(c => c.ReportID == rptid && c.UserID == userid)
                   .Select(c => new UserScores()
                   {
                       Name = c.User.Name,
                       Phone = c.User.Phone,
                       ModuleID = c.ModuleID,
                       ModuleName = c.Module.ModuleName,
                       ModuleTotalScores = c.Module.ModuleTotalScores,
                       FatherModuleID = c.Module.FatherModuleID,
                       Scores = c.Scores
                   });
            return q.ToList();
        }

        public List<rpt_userscores> GetUserScoresByRpt(int rptid, int userid)
        {
            return context.rpt_Userscores.Where(c => c.ReportID == rptid && c.UserID == userid).ToList();
        }
    }
}

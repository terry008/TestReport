using System;
using System.Collections.Generic;
using SKL.Report.Core.Models;
using SKL.Report.Core.Models.DTOModels;

namespace SKL.Report.Core.Services.Interface
{
    public interface IScoresRepository : IBaseRepository<rpt_userscores>, IDependency
    {
        //根据报告id获取成绩
        // List<rpt_userscores> GetScoresByReportID(int rptid);

        List<UserScores> GetUserScores(int rptid, int userid);

        List<rpt_userscores> GetUserScoresByRpt(int rptid,int userid);
    }
}

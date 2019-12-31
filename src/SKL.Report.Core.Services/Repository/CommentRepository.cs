using System;
using System.Collections.Generic;
using SKL.Report.Core.Models;
using SKL.Report.Core.Services.Interface;
using System.Linq;

namespace SKL.Report.Core.Services.Repository
{
    public class CommentRepository : BaseRepository<rpt_comment>, ICommentRepository
    {
        private readonly ReportDBContext context;

        public CommentRepository(ReportDBContext context) : base(context)
        {
            this.context = context;
        }

        public List<rpt_comment> GetCommentByModuleID(int reportid, int moduleid)
        {
            return context.rpt_Comments.Where(c => c.ReportID == reportid && c.ModuleID == moduleid).OrderBy(c=>c.MaxScores).ToList();
        }
    }
}

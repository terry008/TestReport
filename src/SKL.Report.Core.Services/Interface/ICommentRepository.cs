using System;
using System.Collections.Generic;
using SKL.Report.Core.Models;

namespace SKL.Report.Core.Services.Interface
{
    public interface ICommentRepository : IBaseRepository<rpt_comment>, IDependency
    {
        //通过模块ID获取评语
        List<rpt_comment> GetCommentByModuleID(int reportid, int moduleid);
    }
}

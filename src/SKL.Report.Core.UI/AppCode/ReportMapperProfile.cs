using System;
using AutoMapper;
using SKL.Report.Core.Models;
using SKL.Report.Core.UI.Models;
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;

namespace SKL.Report.Core.UI.AppCode
{
//对象映射类
public class ReportMapperProfile : Profile
{
    public ReportMapperProfile()
    {
        CreateMap<rpt_info, ReportEditModel>()
            .ForMember(c => c.OpenDate, o => o.MapFrom(src => string.Format("{0} ~ {1}", src.SearchOpenStart.ToString("yyyy-MM-dd"), src.SearchOpenEnd.ToString("yyyy-MM-dd"))));
        CreateMap<ReportEditModel, rpt_info>()
            .ForMember(c => c.SearchOpenStart, opt => opt.MapFrom(src => Convert.ToDateTime(src.OpenDate.Substring(0, 10))))
            .ForMember(c => c.SearchOpenEnd, opt => opt.MapFrom(src => Convert.ToDateTime(src.OpenDate.Substring(13))));

            // CreateMap<rpt_modules,ModuleTreeModel>()
            // .ForMember(c=>c.title,opt=>opt.MapFrom(scr=>scr.ModuleName))
            // .ForMember(c=>c.children,opt=>opt.MapFrom(src=>src.))
    }
}
}

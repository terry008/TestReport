#pragma checksum "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b429a5e365361d99b2fe64a6d7faf791e3b1e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SubjectTable_SubjectTable), @"mvc.1.0.view", @"/Views/Shared/Components/SubjectTable/SubjectTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SubjectTable/SubjectTable.cshtml", typeof(AspNetCore.Views_Shared_Components_SubjectTable_SubjectTable))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\_ViewImports.cshtml"
using SKL.Report.Core.UI;

#line default
#line hidden
#line 2 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\_ViewImports.cshtml"
using SKL.Report.Core.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b429a5e365361d99b2fe64a6d7faf791e3b1e49", @"/Views/Shared/Components/SubjectTable/SubjectTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa93d0e22c40767bd286b41a09736d50e5494fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SubjectTable_SubjectTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SKL.Report.Core.UI.Models.ModulesDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
  
    bool showSort=(bool)ViewData["showSort"];

#line default
#line hidden
#line 5 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
 if(Model!=null&&Model.Count()>0){


#line default
#line hidden
            BeginContext(153, 618, true);
            WriteLiteral(@"                                    <div class=""infotable table-responsive"">
                                        <table class=""table table-bordered table-hover table-responsive"" style=""text-align: center;"">
                                            <thead>
                                                <tr style=""background-color: #ffd2ab;"">
                                                    <th>模块</th>
                                                    <th>总分</th>
                                                    <th>平均分</th>
                                                    <th>我的得分</th>
");
            EndContext();
#line 15 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                     if(showSort){

#line default
#line hidden
            BeginContext(839, 67, true);
            WriteLiteral("                                                    <th>模块排名</th>\r\n");
            EndContext();
#line 17 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(961, 162, true);
            WriteLiteral("                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
            EndContext();
#line 21 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                 foreach (var module in Model)
                                                {

#line default
#line hidden
            BeginContext(1254, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(1381, 17, false);
#line 24 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                           Write(module.ModuleName);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(1470, 24, false);
#line 25 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                           Write(module.ModuleTotalScores);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(1566, 22, false);
#line 26 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                           Write(module.ModuleAvgScores);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(1660, 21, false);
#line 27 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                           Write(module.MyModuleScores);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 28 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                              if(showSort){

#line default
#line hidden
            BeginContext(1765, 64, true);
            WriteLiteral("                                                            <td>");
            EndContext();
            BeginContext(1830, 19, false);
#line 29 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                           Write(module.MyModuleSort);

#line default
#line hidden
            EndContext();
            BeginContext(1849, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 30 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(1919, 115, true);
            WriteLiteral("                                                        </tr>                                                    \r\n");
            EndContext();
#line 32 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2085, 148, true);
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n                                    </div>\r\n");
            EndContext();
#line 36 "g:\WorkProjects\TestReport\trunk\SKL_Report_Core\src\SKL.Report.Core.UI\Views\Shared\Components\SubjectTable\SubjectTable.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SKL.Report.Core.UI.Models.ModulesDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591

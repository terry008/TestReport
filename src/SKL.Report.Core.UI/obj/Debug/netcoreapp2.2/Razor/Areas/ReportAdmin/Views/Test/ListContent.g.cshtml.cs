#pragma checksum "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fde6f1dbcbccaf26568403d2c6466f49ae2d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ReportAdmin_Views_Test_ListContent), @"mvc.1.0.view", @"/Areas/ReportAdmin/Views/Test/ListContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ReportAdmin/Views/Test/ListContent.cshtml", typeof(AspNetCore.Areas_ReportAdmin_Views_Test_ListContent))]
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
#line 1 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/_ViewImports.cshtml"
using SKL.Report.Core.UI;

#line default
#line hidden
#line 2 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/_ViewImports.cshtml"
using SKL.Report.Core.UI.Models;

#line default
#line hidden
#line 3 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/_ViewImports.cshtml"
using SKL.Report.Core.UI.Areas.ReportAdmin.Models;

#line default
#line hidden
#line 4 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/_ViewImports.cshtml"
using SKL.Report.Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fde6f1dbcbccaf26568403d2c6466f49ae2d30", @"/Areas/ReportAdmin/Views/Test/ListContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fdc0f39ef77b1a2e241c76302a7505fed5762a6", @"/Areas/ReportAdmin/Views/_ViewImports.cshtml")]
    public class Areas_ReportAdmin_Views_Test_ListContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<rpt_info>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 319, true);
            WriteLiteral(@"
<table class=""layui-table"">
    <thead>
        <tr>
            <th>ID
            </th>
            <th>考试名称
            </th>
            <th>状态
            </th>
            <th>人数
            </th>
            <th>查询次数
            </th>
            <th>操作
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
 if(Model!=null&&Model.Count()>0)
    {
        

#line default
#line hidden
#line 23 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
         foreach (var item in Model)
        {            

#line default
#line hidden
            BeginContext(447, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(494, 7, false);
#line 27 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(501, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(554, 15, false);
#line 30 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
           Write(item.ReportName);

#line default
#line hidden
            EndContext();
            BeginContext(569, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(622, 11, false);
#line 33 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(633, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(686, 14, false);
#line 36 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
           Write(item.TestCount);

#line default
#line hidden
            EndContext();
            BeginContext(700, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(753, 16, false);
#line 39 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
           Write(item.SearchCount);

#line default
#line hidden
            EndContext();
            BeginContext(769, 84, true);
            WriteLiteral("\n            </td>\n            <td>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(854, 7, false);
#line 42 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(861, 86, true);
            WriteLiteral("\" data-action=\"scoresDetail\">成绩详情</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(948, 7, false);
#line 43 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(955, 82, true);
            WriteLiteral("\" data-action=\"EditTest\">修改信息</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1038, 7, false);
#line 44 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1045, 81, true);
            WriteLiteral("\" data-action=\"TestSet\">考试设置</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1127, 7, false);
#line 45 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 86, true);
            WriteLiteral("\" data-action=\"ImportScores\">导入成绩</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1221, 7, false);
#line 46 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 79, true);
            WriteLiteral("\" data-action=\"PYSet\">评语设置</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1308, 7, false);
#line 47 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 81, true);
            WriteLiteral("\" data-action=\"Preview\">查询预览</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1397, 7, false);
#line 48 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 79, true);
            WriteLiteral("\" data-action=\"Qr\">生成查询二维码</a>\n                <a href=\"javascript:;\" data-id=\"");
            EndContext();
            BeginContext(1484, 7, false);
#line 49 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
                                           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 67, true);
            WriteLiteral("\" data-action=\"SetModule\">模块管理</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 52 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
        }

#line default
#line hidden
#line 52 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Areas/ReportAdmin/Views/Test/ListContent.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1574, 154, true);
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"6\" class=\"tocenter\">\n                \n            </td>\n        </tr>\n    </tfoot>\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<rpt_info>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6640979bec1255a9da49a0f79a606f21fb6a31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Chart_Chart), @"mvc.1.0.view", @"/Views/Shared/Components/Chart/Chart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Chart/Chart.cshtml", typeof(AspNetCore.Views_Shared_Components_Chart_Chart))]
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
#line 1 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/_ViewImports.cshtml"
using SKL.Report.Core.UI;

#line default
#line hidden
#line 2 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/_ViewImports.cshtml"
using SKL.Report.Core.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6640979bec1255a9da49a0f79a606f21fb6a31a", @"/Views/Shared/Components/Chart/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e0eddb32aab0f06c69af33c9289fb747c699d51", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Chart_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SKL.Report.Core.UI.Models.ModulesDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
  
    string modules=string.Join(",",Model.Select(c=>$"'{c.ModuleName}'"));
    string myScores=string.Join(",",Model.Select(c=>c.MyModuleScores.ToString("n")));
    string avgScores=string.Join(",",Model.Select(c=>c.ModuleAvgScores.ToString("n")));
    string guid=Guid.NewGuid().ToString("N");

#line default
#line hidden
            BeginContext(359, 14, true);
            WriteLiteral("<div>\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 373, "\"", 383, 1);
#line 9 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
WriteAttributeValue("", 378, guid, 378, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 82, true);
            WriteLiteral(" class=\"zhu_tu\"></div>\n    <script>\n        echarts.init(document.getElementById(\'");
            EndContext();
            BeginContext(467, 4, false);
#line 11 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
                                         Write(guid);

#line default
#line hidden
            EndContext();
            BeginContext(471, 334, true);
            WriteLiteral(@"')).setOption({
                tooltip: {
                    trigger: 'axis',
                    axisPointer: {
                        type: 'cross'
                    }
                },
                legend: {
                    data: ['我的得分', '平均分']
                },
                xAxis: [{
                    data: [");
            EndContext();
            BeginContext(806, 17, false);
#line 22 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
                      Write(Html.Raw(modules));

#line default
#line hidden
            EndContext();
            BeginContext(823, 170, true);
            WriteLiteral("]\n                }],\n                yAxis: {},\n                series: [{\n                    name: \'我的得分\',\n                    type: \'bar\',\n                    data: [");
            EndContext();
            BeginContext(995, 8, false);
#line 28 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
                       Write(myScores);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 117, true);
            WriteLiteral("]\n                }, {\n                    name: \'平均分\',\n                    type: \'line\',\n                    data: [");
            EndContext();
            BeginContext(1123, 9, false);
#line 32 "/Users/pandanting/Projects/TestReport/src/SKL.Report.Core.UI/Views/Shared/Components/Chart/Chart.cshtml"
                       Write(avgScores);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 57, true);
            WriteLiteral("]\n                }]\n            });\n    </script>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SKL.Report.Core.UI.Models.ModulesDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591

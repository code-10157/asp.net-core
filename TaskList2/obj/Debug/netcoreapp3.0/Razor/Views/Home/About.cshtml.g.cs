#pragma checksum "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49527f3b2acb96dd5b414ec6a6ae894d0bfb9614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#nullable restore
#line 1 "C:\Users\m_kita\source\repos\TaskList2\Views\_ViewImports.cshtml"
using TaskList2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m_kita\source\repos\TaskList2\Views\_ViewImports.cshtml"
using TaskList2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49527f3b2acb96dd5b414ec6a6ae894d0bfb9614", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13efa9007e9e8cd37a24636fa95bb15aead1853e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskList2.Models.ProjectViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml"
  
    ViewData["Title"] = "SumTask";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>集計とか※工事中</h4>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            ---開始日---\r\n        </th>\r\n\r\n        <th>\r\n            ---登録数---\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("&emsp;\r\n            </td>\r\n            <td align=\"center\">\r\n                ");
#nullable restore
#line 27 "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml"
           Write(item.ProjectCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\m_kita\source\repos\TaskList2\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskList2.Models.ProjectViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591

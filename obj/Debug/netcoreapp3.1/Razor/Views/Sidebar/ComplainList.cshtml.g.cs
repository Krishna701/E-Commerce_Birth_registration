#pragma checksum "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0ce72c57e7033586f6d33b9af7256a3ab1cde9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sidebar_ComplainList), @"mvc.1.0.view", @"/Views/Sidebar/ComplainList.cshtml")]
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
#line 1 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\_ViewImports.cshtml"
using EGovProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\_ViewImports.cshtml"
using EGovProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0ce72c57e7033586f6d33b9af7256a3ab1cde9", @"/Views/Sidebar/ComplainList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4790743ad3657166bcec9aeca26620d75c400287", @"/Views/_ViewImports.cshtml")]
    public class Views_Sidebar_ComplainList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EGovProject.Models.ViewModel.ComplainModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
  
    ViewData["Title"] = "ComplainList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int counter = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    .table {
        overflow-y: auto;
        border-radius: 50px;
        padding: 1rem;
    }

    table {
        width: 100%;
        text-align: center;
        border-collapse: collapse;
    }

        table thead th,
        table tbody td {
            padding: 15px;
            border: none;
            font-weight: 600;
            font-size: 14px;
        }

        table thead th {
            background: #1861ac;
            color: white;
            font-size: 16px;
            position: sticky;
            top: -1%;
        }

        table tbody td {
            border-bottom: 1px solid rgba(0,0,0,0.1);
            border-left: 1px solid rgba(0,0,0,0.1);
        }
</style>


<h1>   सुझाव तथा गुनासोहरुको सूची</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
              नं
            </th>
            <th>
          नाम
            </th>
            <th>
              प्रकार
            </th>
            <");
            WriteLiteral("th>\r\n             मिति/समय\r\n            </th>\r\n            <th>\r\n                विवरण\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 73 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                   ");
#nullable restore
#line 77 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
              Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplainDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 93 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Sidebar\ComplainList.cshtml"
            counter++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EGovProject.Models.ViewModel.ComplainModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2455f63e997f3680e430bc8813fe2b3f5e9967e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birth_List), @"mvc.1.0.view", @"/Views/Birth/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2455f63e997f3680e430bc8813fe2b3f5e9967e", @"/Views/Birth/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4790743ad3657166bcec9aeca26620d75c400287", @"/Views/_ViewImports.cshtml")]
    public class Views_Birth_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EGovProject.Models.ViewModel.BirthModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int Counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<script type=""text/javascript""
        charset=""utf8""
         src=""https://code.jquery.com/jquery-3.3.1.js""></script>
<script type=""text/javascript""
        charset=""utf8""
        src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function () {
        $(""#table_id"").DataTable({
            ajax: ""./ajaxList.txt""
        });
    });
</script>

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

      ");
            WriteLiteral("  table tbody td {\r\n            border-bottom: 1px solid rgba(0,0,0,0.1);\r\n            border-left: 1px solid rgba(0,0,0,0.1);\r\n        }\r\n</style>\r\n\r\n\r\n\r\n\r\n<div>\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2455f63e997f3680e430bc8813fe2b3f5e9967e4956", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>
    <table class=""table"" id=""myTable"">
        <thead>
            <tr>
                <th>
                    दर्ता न./ Registration No
                </th>
                <th>
                    दर्ता मिति / Registration Date
                </th>

                <th>
                    पुरा नाम/ Full Name
                </th>


                <th>
                    जन्म मिति / DOB
                </th>

                <th>
                    लिंग/Gender
                </th>
                <th>
                    जन्म स्थान/ Birth place
                </th>


                <th>
                    हजुरबुबाको नाम /Grandfather's  Name
                </th>

                <th>
                    बुबाको नाम / Father's Name
                </th>

                <th>
                    आमाको नाम / Mother's Name
                </th>

");
            WriteLiteral("                <th>\r\n\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 118 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 122 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 125 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegistrationDateNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral(" B.S/\r\n                        ");
#nullable restore
#line 126 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegistrationDateEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral(" A.D\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 130 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FNameNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 130 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.MNameNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 130 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                       Write(Html.DisplayFor(modelItem => item.LNameNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r\n                        ");
#nullable restore
#line 131 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FNameEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 131 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.MNameEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 131 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                         Write(Html.DisplayFor(modelItem => item.LNameEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 138 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NDOBBSY));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 138 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.NDOBBSM));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 138 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => item.NDOBBSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("B.S /\r\n                        ");
#nullable restore
#line 139 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EDOBBSY));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 139 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.EDOBBSM));

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 139 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => item.EDOBBSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("A.D\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 144 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                        <script>\r\n                            var sex = \"");
#nullable restore
#line 146 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                            if (sex == ""Male"")
                                document.write(""पुरुष"")
                            else if (sex == ""Female"")
                                document.write(""महिला"");
                            else
                                document.write(""तेस्रो लिंगी"");

                        </script>
                    </td>
                    <td>
                        ");
#nullable restore
#line 157 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BirthPlaceNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("/ ");
#nullable restore
#line 157 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.BirthPlaceEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 161 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GFFNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 161 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.GFMNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 161 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => item.GFLNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                        ");
#nullable restore
#line 162 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.GFFEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 162 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.GFMEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 162 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                       Write(Html.DisplayFor(modelItem => item.GFLEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 167 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherFNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 167 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.FatherMNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 167 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.FatherLNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                        ");
#nullable restore
#line 168 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FatherFEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 168 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.FatherMEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 168 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                           Write(Html.DisplayFor(modelItem => item.FatherLEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 172 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherFNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 172 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.MotherMNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 172 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                            Write(Html.DisplayFor(modelItem => item.MotherLNepali));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                        ");
#nullable restore
#line 173 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MotherFEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 173 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.MotherMEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 173 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                                                                                                                             Write(Html.DisplayFor(modelItem => item.MotherLEnglish));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 181 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.ActionLink("", "Edit", new { registrationNumber = item.RegistrationNumber }, new { @class = "fa fa-edit" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 182 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.ActionLink("", "BirthCertificate", new { registrationNumber = item.RegistrationNumber }, new { @class = "fa fa-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 183 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                   Write(Html.ActionLink("", "Delete", new { registrationNumber = item.RegistrationNumber }, new { @class = "fa fa-trash" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 187 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Birth\List.cshtml"
                Counter++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EGovProject.Models.ViewModel.BirthModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

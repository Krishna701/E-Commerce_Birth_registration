#pragma checksum "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585de6a9489bf613af5bbc80e61c7d92b794ebc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PollResult), @"mvc.1.0.view", @"/Views/Home/PollResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585de6a9489bf613af5bbc80e61c7d92b794ebc4", @"/Views/Home/PollResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4790743ad3657166bcec9aeca26620d75c400287", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PollResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EGovProject.Models.ViewModel.PollModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
  
    int counter = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
 foreach (var item in Model)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
Write(Html.DisplayFor(modelItem => item.Choose));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
                                              
    counter++;


 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    int yesCounter = 0;\r\n    int noCounter = 0;\r\n\r\n    if (\"");
#nullable restore
#line 19 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
    Write(Html.DisplayFor(modelItem => item.Choose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"== \"Yes\") {\r\n\r\n        yesCounter++;\r\n        document.write(yesCounter);\r\n    }\r\n\r\n    else {\r\n        noCounter++;\r\n        document.write(noCounter);\r\n    }\r\n\r\n</script>\r\n");
#nullable restore
#line 31 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"


           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\Net centriccprojct\EGovProject_1632811437\EGovProject\Views\Home\PollResult.cshtml"
Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    document.write(yesCounter);\r\n    document.write(noCounter);\r\n    document.write(eval(\"yesCounter+noCounter\"));\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EGovProject.Models.ViewModel.PollModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
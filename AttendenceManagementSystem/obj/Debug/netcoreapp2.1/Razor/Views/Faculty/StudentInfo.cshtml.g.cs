#pragma checksum "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5737b787e6994ba414aea22880e6d73b3769f42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_StudentInfo), @"mvc.1.0.view", @"/Views/Faculty/StudentInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Faculty/StudentInfo.cshtml", typeof(AspNetCore.Views_Faculty_StudentInfo))]
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
#line 1 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\_ViewImports.cshtml"
using AttendenceManagementSystem;

#line default
#line hidden
#line 2 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\_ViewImports.cshtml"
using AttendenceManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5737b787e6994ba414aea22880e6d73b3769f42f", @"/Views/Faculty/StudentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528f9538927821b5160986825edc5a5130bb5c39", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_StudentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AttendenceManagementSystem.ViewModel.GuardianInfoVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
  
    ViewData["Title"] = "StudentInfo";

#line default
#line hidden
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(119, 33, false);
#line 7 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
Write(Html.Partial("_FacultyDashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(152, 577, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""container-fluid"" style=""padding-top:60px;padding-bottom:60px;position:relative;"">
        <h1 class=""text-center"">Profile</h1>
        <div class=""card"" style=""width:80%;margin-left: 50%;transform: translateX(-50%);"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-6"" style=""border-right:2px solid"">
                        <h5 style=""border-bottom:2px solid"">Student:</h5>
                        <i class=""fas fa-user fa-8x""></i>
                        <h5>Id : ");
            EndContext();
            BeginContext(730, 18, false);
#line 18 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                            Write(ViewBag.stuInfo.Id);

#line default
#line hidden
            EndContext();
            BeginContext(748, 41, true);
            WriteLiteral("</h5>\r\n                        <h5>Name :");
            EndContext();
            BeginContext(790, 25, false);
#line 19 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                             Write(ViewBag.stuInfo.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(815, 8, true);
            WriteLiteral(" &nbsp; ");
            EndContext();
            BeginContext(824, 24, false);
#line 19 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                                                               Write(ViewBag.stuInfo.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(848, 234, true);
            WriteLiteral("</h5>                       \r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <h5 style=\"border-bottom:2px solid\">Guardian:</h5>\r\n                        <i class=\"fas fa-user fa-8x\"></i>\r\n");
            EndContext();
#line 24 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1163, 37, true);
            WriteLiteral("                            <h5>Id : ");
            EndContext();
            BeginContext(1201, 10, false);
#line 26 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                                Write(item.GidVM);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 46, true);
            WriteLiteral("</h5>\r\n                            <h5>Name : ");
            EndContext();
            BeginContext(1258, 12, false);
#line 27 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                                  Write(item.GNameVM);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 47, true);
            WriteLiteral("</h5>\r\n                            <h5>Phone : ");
            EndContext();
            BeginContext(1318, 13, false);
#line 28 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                                   Write(item.GPhoneVM);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 47, true);
            WriteLiteral("</h5>\r\n                            <h5>Email : ");
            EndContext();
            BeginContext(1379, 12, false);
#line 29 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                                   Write(item.GMailVM);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 30 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\StudentInfo.cshtml"
                        }

#line default
#line hidden
            BeginContext(1425, 110, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AttendenceManagementSystem.ViewModel.GuardianInfoVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

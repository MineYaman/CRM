#pragma checksum "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e16c8a7db1be2eb7330ffff7034b6693cc05c91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AspNetUserRole_ListAspNetUsers), @"mvc.1.0.view", @"/Views/AspNetUserRole/ListAspNetUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AspNetUserRole/ListAspNetUsers.cshtml", typeof(AspNetCore.Views_AspNetUserRole_ListAspNetUsers))]
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
#line 2 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\_ViewImports.cshtml"
using CRM.Entities;

#line default
#line hidden
#line 3 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\_ViewImports.cshtml"
using CRM.WebUI.Extensions;

#line default
#line hidden
#line 4 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\_ViewImports.cshtml"
using CRM.WebUI.Models;

#line default
#line hidden
#line 5 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\_ViewImports.cshtml"
using CRM.WebUI.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e16c8a7db1be2eb7330ffff7034b6693cc05c91", @"/Views/AspNetUserRole/ListAspNetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3881a1498793922623b3493f3b1d72578965650", @"/Views/_ViewImports.cshtml")]
    public class Views_AspNetUserRole_ListAspNetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
  
    ViewData["Title"] = "ListAspNetUsers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 32, true);
            WriteLiteral("\r\n<h1>ListAspNetUsers</h1>\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
            BeginContext(201, 264, true);
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>Name</td>
                <td style=""width:12px;"">Deleted</td>
                <td style=""width:150px;""></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 24 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(522, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(569, 13, false);
#line 27 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
                   Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(582, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(614, 12, false);
#line 28 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
                   Write(item.Deleted);

#line default
#line hidden
            EndContext();
            BeginContext(626, 95, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 721, "\"", 760, 2);
            WriteAttributeValue("", 728, "/department/departments/", 728, 24, true);
#line 30 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
WriteAttributeValue("", 752, item.Id, 752, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(761, 35, true);
            WriteLiteral(">Edit</a>\r\n                        ");
            EndContext();
            BeginContext(796, 311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e16c8a7db1be2eb7330ffff7034b6693cc05c917072", async() => {
                BeginContext(887, 70, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"departmentId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 957, "\"", 973, 1);
#line 32 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
WriteAttributeValue("", 965, item.Id, 965, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(974, 126, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 810, "/department/deletedepartment/", 810, 29, true);
#line 31 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
AddHtmlAttributeValue("", 839, item.Id, 839, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1107, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
            }

#line default
#line hidden
            BeginContext(1174, 36, true);
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n");
            EndContext();
#line 42 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1222, 84, true);
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>No Departments</h4>\r\n    </div>\r\n");
            EndContext();
#line 48 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\AspNetUserRole\ListAspNetUsers.cshtml"
}

#line default
#line hidden
            BeginContext(1309, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

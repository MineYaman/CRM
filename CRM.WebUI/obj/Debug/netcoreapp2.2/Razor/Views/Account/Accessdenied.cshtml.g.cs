#pragma checksum "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\Account\Accessdenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c67bc181ebbb5b3e02a5c1c82483d167d4578b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Accessdenied), @"mvc.1.0.view", @"/Views/Account/Accessdenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Accessdenied.cshtml", typeof(AspNetCore.Views_Account_Accessdenied))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c67bc181ebbb5b3e02a5c1c82483d167d4578b87", @"/Views/Account/Accessdenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3881a1498793922623b3493f3b1d72578965650", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Accessdenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\asus\Desktop\MineYaman\CRM\CRM.WebUI\Views\Account\Accessdenied.cshtml"
  
    ViewData["Title"] = "Accessdenied";

#line default
#line hidden
            BeginContext(50, 72, true);
            WriteLiteral("\r\n<div class=\"alert alert-danger\">Yetkinizin Olmadığı Bir Alan</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c9a3a78f1961069b14058324d42eb448a18dd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactPost), @"mvc.1.0.view", @"/Views/Home/ContactPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactPost.cshtml", typeof(AspNetCore.Views_Home_ContactPost))]
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
#line 1 "D:\supachai 016\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\supachai 016\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c9a3a78f1961069b14058324d42eb448a18dd2", @"/Views/Home/ContactPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
  
    ViewData["Title"] = "ขอบคุณที่ติดต่อเรา";

#line default
#line hidden
            BeginContext(56, 51, true);
            WriteLiteral("\r\n<h1>ขอบคุณที่ติดต่อเรา</h1>\r\n<div>ทางเราขอขอบคุณ ");
            EndContext();
            BeginContext(108, 16, false);
#line 7 "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
               Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 64, true);
            WriteLiteral(" เมื่อเจ้าหน้าที่รับเรื่องเเล้วทางเราจะติดต่อกลับไปที่\r\n        ");
            EndContext();
            BeginContext(189, 17, false);
#line 8 "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\ContactPost.cshtml"
   Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(206, 16, true);
            WriteLiteral(" โดยด่วน</div>\r\n");
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
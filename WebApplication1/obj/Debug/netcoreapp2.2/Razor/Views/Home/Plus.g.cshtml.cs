#pragma checksum "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\Plus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2079cabcebe83c07d8ad7196db8779fcb4dcedc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Plus), @"mvc.1.0.view", @"/Views/Home/Plus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Plus.cshtml", typeof(AspNetCore.Views_Home_Plus))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2079cabcebe83c07d8ad7196db8779fcb4dcedc0", @"/Views/Home/Plus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Plus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\Plus.cshtml"
  
    ViewData["Title"] = "Plus";

#line default
#line hidden
            BeginContext(42, 17, true);
            WriteLiteral("\r\n<h1>Plus</h1>\r\n");
            EndContext();
            BeginContext(60, 17, false);
#line 7 "D:\supachai 016\WebApplication1\WebApplication1\Views\Home\Plus.cshtml"
Write(ViewData["plus1"]);

#line default
#line hidden
            EndContext();
            BeginContext(77, 5, true);
            WriteLiteral(";\r\n\r\n");
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

#pragma checksum "E:\FFTraining\ExceptionalHandling\ExceptionalHandling\Views\Home\newError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a48164fab5af829d12bfcbfe26d0455cb78524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_newError), @"mvc.1.0.view", @"/Views/Home/newError.cshtml")]
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
#line 1 "E:\FFTraining\ExceptionalHandling\ExceptionalHandling\Views\_ViewImports.cshtml"
using ExceptionalHandling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FFTraining\ExceptionalHandling\ExceptionalHandling\Views\_ViewImports.cshtml"
using ExceptionalHandling.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a48164fab5af829d12bfcbfe26d0455cb78524", @"/Views/Home/newError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e75b4d5961874c4b028986b6d2b0fda4516b1ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_newError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\FFTraining\ExceptionalHandling\ExceptionalHandling\Views\Home\newError.cshtml"
  
    ViewData["Title"] = "newError";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>newError</h1>
<h1 class=""text-danger"">Error.</h1>
<h2 class=""text-danger"">An error occurred while processing your request.</h2>

<h3>Development Mode Error</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>

");
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

#pragma checksum "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Second\Fourth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b906642b1e2b462435a096ae6c856ac6b5b5c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Second_Fourth), @"mvc.1.0.view", @"/Views/Second/Fourth.cshtml")]
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
#line 1 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\_ViewImports.cshtml"
using WebApplicationMVCCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\_ViewImports.cshtml"
using WebApplicationMVCCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b906642b1e2b462435a096ae6c856ac6b5b5c4", @"/Views/Second/Fourth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece21334f9d16bf92f860b17bd999f57583ebba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Second_Fourth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Second\Fourth.cshtml"
  
    ViewData["Title"] = "Fourth";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Fourth</h1>\r\n\r\n ");
#nullable restore
#line 8 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Second\Fourth.cshtml"
Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1> Hello ");
#nullable restore
#line 10 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Second\Fourth.cshtml"
      Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<b> Address is ");
#nullable restore
#line 11 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Second\Fourth.cshtml"
          Write(ViewData["address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n");
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
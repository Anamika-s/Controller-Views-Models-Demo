#pragma checksum "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57056348418eb656952871c6f66c9b9ebae27d8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57056348418eb656952871c6f66c9b9ebae27d8d", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece21334f9d16bf92f860b17bd999f57583ebba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> List of Students </h1>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th> ID </th>\r\n        <th> Name </th>\r\n        <th> Batch </th>\r\n        <th> Marks </th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
       foreach (var student in ViewBag.list)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td> ");
#nullable restore
#line 29 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
                Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 30 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
                Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
                Write(student.Batch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 32 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
                Write(student.Marks);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Anamika\source\repos\WebApplicationMVCCore\WebApplicationMVCCore\Views\Student\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>");
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

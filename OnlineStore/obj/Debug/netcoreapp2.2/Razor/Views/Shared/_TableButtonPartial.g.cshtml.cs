#pragma checksum "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4c87a96fa378f7f24da715a5c0626a6205c95f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore;

#line default
#line hidden
#line 2 "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4c87a96fa378f7f24da715a5c0626a6205c95f", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85bb3a1f5b42cee7936e01fe8aebb63edeff1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(142, 120, true);
            WriteLiteral("\r\n\r\n<td style=\"width:150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 262, "\"", 295, 1);
#line 11 "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 269, Url.Action("Edit/"+Model), 269, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 122, true);
            WriteLiteral(" tooltip=\"Edit\">\r\n            <i  class=\"fas fa-edit\"></i>\r\n        </a>\r\n        <a type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 418, "\"", 454, 1);
#line 14 "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 425, Url.Action("Details/"+Model), 425, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 114, true);
            WriteLiteral(">\r\n            <i class=\"fas fa-file-alt\"></i>\r\n        </a>     \r\n        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 569, "\"", 604, 1);
#line 17 "E:\Other\MyDotNetProjects\OnlineStore\OnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 576, Url.Action("Delete/"+Model), 576, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(605, 77, true);
            WriteLiteral(">\r\n            <i  class=\"fas fa-trash\"></i>\r\n        </a>\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591

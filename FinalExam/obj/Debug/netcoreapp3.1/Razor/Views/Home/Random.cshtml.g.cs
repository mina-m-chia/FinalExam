#pragma checksum "/Users/minachia/Downloads/FinalExam/FinalExam/Views/Home/Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af46e2cbd57d15d1211af25dbeb1946217cc2c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Random), @"mvc.1.0.view", @"/Views/Home/Random.cshtml")]
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
#line 1 "/Users/minachia/Downloads/FinalExam/FinalExam/Views/_ViewImports.cshtml"
using FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/minachia/Downloads/FinalExam/FinalExam/Views/_ViewImports.cshtml"
using FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af46e2cbd57d15d1211af25dbeb1946217cc2c01", @"/Views/Home/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a1081c3ab7d882e6821399a24ff4b4b9f3be57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/minachia/Downloads/FinalExam/FinalExam/Views/Home/Random.cshtml"
  
    ViewData["Title"] = "Random Quote";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Random Quote</h1>\n\n<p><i>");
#nullable restore
#line 9 "/Users/minachia/Downloads/FinalExam/FinalExam/Views/Home/Random.cshtml"
 Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> by ");
#nullable restore
#line 9 "/Users/minachia/Downloads/FinalExam/FinalExam/Views/Home/Random.cshtml"
                    Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quote> Html { get; private set; }
    }
}
#pragma warning restore 1591
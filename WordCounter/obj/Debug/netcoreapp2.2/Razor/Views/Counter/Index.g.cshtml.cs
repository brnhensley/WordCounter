#pragma checksum "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ab5c7fd0747414bf82484312769156fa5adbc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counter_Index), @"mvc.1.0.view", @"/Views/Counter/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Counter/Index.cshtml", typeof(AspNetCore.Views_Counter_Index))]
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
#line 1 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
using WordCounter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ab5c7fd0747414bf82484312769156fa5adbc2", @"/Views/Counter/Index.cshtml")]
    public class Views_Counter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 50, true);
            WriteLiteral("\n\n<h3>Here is your word count!</h3>\n\n<h1>The word ");
            EndContext();
            BeginContext(78, 15, false);
#line 6 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
        Write(Model.GetWord());

#line default
#line hidden
            EndContext();
            BeginContext(93, 9, true);
            WriteLiteral(" appears ");
            EndContext();
            BeginContext(103, 18, false);
#line 6 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
                                 Write(Model.GetMatches());

#line default
#line hidden
            EndContext();
            BeginContext(121, 77, true);
            WriteLiteral(" times in your sentence!</h1>\n\n<a href=\"/counter/new\">Let\'s do it again!</a>\n");
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

#pragma checksum "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c974921ca1d99720dd49247c536719579d3254"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c974921ca1d99720dd49247c536719579d3254", @"/Views/Counter/Index.cshtml")]
    public class Views_Counter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(55, 74, true);
            WriteLiteral("\n<center><h3>Here is your word count!</h3></center>\n\n<center><h1>The word ");
            EndContext();
            BeginContext(130, 14, false);
#line 9 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
                Write(Model.UserWord);

#line default
#line hidden
            EndContext();
            BeginContext(144, 9, true);
            WriteLiteral(" appears ");
            EndContext();
            BeginContext(154, 17, false);
#line 9 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
                                        Write(Model.WordMatches);

#line default
#line hidden
            EndContext();
            BeginContext(171, 51, true);
            WriteLiteral(" times in your sentence:</h1></center>\n<center><h3>");
            EndContext();
            BeginContext(223, 18, false);
#line 10 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/Index.cshtml"
       Write(Model.UserSentence);

#line default
#line hidden
            EndContext();
            BeginContext(241, 70, true);
            WriteLiteral("</h3></center>\n\n<h2><a href=\"/counter/new\">Want to go again!</a></h2>\n");
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

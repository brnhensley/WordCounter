#pragma checksum "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d053fc8aade0ae1b7e02b8edbba24211442f1c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counter_New), @"mvc.1.0.view", @"/Views/Counter/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Counter/New.cshtml", typeof(AspNetCore.Views_Counter_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d053fc8aade0ae1b7e02b8edbba24211442f1c5b", @"/Views/Counter/New.cshtml")]
    public class Views_Counter_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/admin/Documents/Code/WordCounter.Solution/WordCounter/Views/Counter/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 465, true);
            WriteLiteral(@"
<center>
  <h1>Let's count some words!</h1>
  <h2>Enter a word and a sentence and I'll tell you how many time the word appears in the sentence!</h2>
</center>

<form action=""/counter"" method=""post"">

  <label for=""userWord"">Give me a word!</label>
  <input id=""userWord"" name=""userWord"" type=""text"">

  <label for=""userSentence"">Enter a sentence!</label>
  <input id=""userSentence"" name=""userSentence"" type=""text"">

  <button type=""submit"">Submit</button>
</form>
");
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

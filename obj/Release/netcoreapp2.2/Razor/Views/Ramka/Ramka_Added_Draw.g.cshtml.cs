#pragma checksum "C:\Users\Кирилл\Desktop\Geoportal\Geoportal\Views\Ramka\Ramka_Added_Draw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5eef4eeca1c50762be37b6c2fbcf7428a2cd8d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ramka_Ramka_Added_Draw), @"mvc.1.0.view", @"/Views/Ramka/Ramka_Added_Draw.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ramka/Ramka_Added_Draw.cshtml", typeof(AspNetCore.Views_Ramka_Ramka_Added_Draw))]
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
#line 1 "C:\Users\Кирилл\Desktop\Geoportal\Geoportal\Views\_ViewImports.cshtml"
using Geoportal;

#line default
#line hidden
#line 2 "C:\Users\Кирилл\Desktop\Geoportal\Geoportal\Views\_ViewImports.cshtml"
using Geoportal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5eef4eeca1c50762be37b6c2fbcf7428a2cd8d7", @"/Views/Ramka/Ramka_Added_Draw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80c61fa86dc36c6e058b2d9559c6cd93bd7654d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ramka_Ramka_Added_Draw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Кирилл\Desktop\Geoportal\Geoportal\Views\Ramka\Ramka_Added_Draw.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 64, true);
            WriteLiteral("<h1>Рамка была успешна добавлена</h1>\r\n<p>Номер рамки: </p>\r\n<p>");
            EndContext();
            BeginContext(97, 18, false);
#line 6 "C:\Users\Кирилл\Desktop\Geoportal\Geoportal\Views\Ramka\Ramka_Added_Draw.cshtml"
Write(ViewData["Cmr_id"]);

#line default
#line hidden
            EndContext();
            BeginContext(115, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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

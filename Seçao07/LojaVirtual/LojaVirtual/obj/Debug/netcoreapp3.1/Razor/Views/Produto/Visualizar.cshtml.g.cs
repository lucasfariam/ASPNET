#pragma checksum "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66cc7e174e08f074f1c75ff2c398e3211bc8385e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cc7e174e08f074f1c75ff2c398e3211bc8385e", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" LojaVirtual.Models.Produto\r\n\r\n<br />\r\n<h2>Produto</h2>\r\n<b>Codigo:");
#nullable restore
#line 5 "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n<b>Nome:");
#nullable restore
#line 6 "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
   Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n<b>Descrição:");
#nullable restore
#line 7 "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n<b>Valor:");
#nullable restore
#line 8 "C:\Users\lucas.moura\Desktop\ASPNET\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
    Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />");
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

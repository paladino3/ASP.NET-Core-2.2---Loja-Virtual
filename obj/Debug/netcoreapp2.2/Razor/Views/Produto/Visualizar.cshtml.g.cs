#pragma checksum "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aafa716b158d7612fb9287a755134c7ce71b8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
#line 2 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aafa716b158d7612fb9287a755134c7ce71b8be", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24cae35da25152a897b798ae02ba4e2d62399ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
  
    ViewData["Title"] = "Produto";

#line default
#line hidden
            BeginContext(78, 52, true);
            WriteLiteral("\r\n<h3>Produto -> Visualizar</h3>\r\n\r\n\r\n:)\r\n<br />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Wesley rolim";

#line default
#line hidden
            BeginContext(172, 16, true);
            WriteLiteral("\r\n<br />\r\n\r\n<h2>");
            EndContext();
            BeginContext(189, 4, false);
#line 18 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
            EndContext();
            BeginContext(193, 48, true);
            WriteLiteral("</h2>\r\n<br />\r\n<h2>Produto</h2>\r\n<b>Código:</b> ");
            EndContext();
            BeginContext(242, 8, false);
#line 21 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(250, 23, true);
            WriteLiteral("\r\n<br />\r\n<b>Nome:</b> ");
            EndContext();
            BeginContext(274, 10, false);
#line 23 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(284, 28, true);
            WriteLiteral("\r\n<br />\r\n<b>Descrição:</b> ");
            EndContext();
            BeginContext(313, 15, false);
#line 25 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(328, 24, true);
            WriteLiteral("\r\n<br />\r\n<b>Valor:</b> ");
            EndContext();
            BeginContext(353, 25, false);
#line 27 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(378, 54, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(433, 17, false);
#line 30 "C:\Users\rolim\Desktop\Nova pasta\ASP.NET-Core-2.2---Loja-Virtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591

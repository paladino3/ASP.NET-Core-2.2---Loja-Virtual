#pragma checksum "C:\Users\rolim\Desktop\LojaVirtual\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ba5d70d388c4364a19d8a9c98e6ccb44b91770"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ba5d70d388c4364a19d8a9c98e6ccb44b91770", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\rolim\Desktop\LojaVirtual\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(43, 1982, true);
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <section class=""container"">
        <aside class=""col-sm-4"">
            <h3 class=""subtitle-doc"">
                # Login form simple
                <a href=""#"" data-html=""code_login_1"" class=""showcode"">[code]</a>
            </h3>
            <div id=""code_login_1"">
                <div class=""card"">
                    <article class=""card-body"">
                        <a href=""/home/cadastro"" class=""float-right btn btn-outline-primary"">Sign up</a>
                        <h4 class=""card-title mb-4 mt-1"">Sign in</h4>
                        <form>
                            <div class=""form-group"">
                                <label>Your email</label>
                                <input name="""" class=""form-control"" placeholder=""Email"" type=""email"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <a class=""float-right"" href=""#"">Forgot?</a>");
            WriteLiteral(@"
                                <label>Your password</label>
                                <input class=""form-control"" placeholder=""******"" type=""password"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <div class=""checkbox"">
                                    <label> <input type=""checkbox""> Save password </label>
                                </div> <!-- checkbox .// -->
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary btn-block""> Login </button>
                            </div> <!-- form-group// -->
                        </form>
                    </article>
                </div> <!-- card.// -->
            </div> <!-- code-wrap.// -->
        </aside>
    </section>
</main>



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

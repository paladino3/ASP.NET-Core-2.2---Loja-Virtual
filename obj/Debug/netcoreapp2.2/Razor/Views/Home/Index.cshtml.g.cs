#pragma checksum "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6394fcaf1e7042accb83d08adcd715b5a4766a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6394fcaf1e7042accb83d08adcd715b5a4766a68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24cae35da25152a897b798ae02ba4e2d62399ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.NewsletterEmail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 9580, true);
            WriteLiteral(@"
    <main role=""main"" style=""background-color: rgb(238, 238, 238);"">

        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""first-slide"" src=""data:imag/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""First slide"">
                    <div class=""container"">
                        <div class=""carousel-caption text-left"">
                            <h1>Example headline.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit no");
            WriteLiteral(@"n mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                            </p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""Second slide"">
                    <div class=""container"">
                        <div class=""carousel-caption"">
                            <h1>Another example headline.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
               ");
            WriteLiteral(@"             </p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                         alt=""Third slide"">
                    <div class=""container"">
                        <div class=""carousel-caption text-right"">
                            <h1>One more for good measure.</h1>
                            <p>
                                Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                            </p>
                            <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
");
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>




        <!-- Lista de Produtos
            ================================================== -->
        <!-- Wrap the rest of the page in another container to center all the content. -->


        <div class=""container"" id=""code_prod_complex"">
            <div class=""row"">
                <div class=""col-md-4"">
                    <figure class=""card card-product"">
         ");
            WriteLiteral(@"               <div class=""img-wrap""><img src=""images/items/1.jpg""></div>
                        <figcaption class=""info-wrap"">
                            <h4 class=""title"">Another name of item</h4>
                            <p class=""desc"">Some small description goes here</p>
                            <div class=""rating-wrap"">
                                <ul class=""rating-stars"">
                                    <li style=""width:80%"" class=""stars-active"">
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                </ul>
                                ");
            WriteLiteral(@"<div class=""label-rating"">132 reviews</div>
                                <div class=""label-rating"">154 orders </div>
                            </div> <!-- rating-wrap.// -->
                        </figcaption>
                        <div class=""bottom-wrap"">
                            <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                            <div class=""price-wrap h5"">
                                <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                            </div> <!-- price-wrap.// -->
                        </div> <!-- bottom-wrap.// -->
                    </figure>
                </div> <!-- col // -->
                <div class=""col-md-4"">
                    <figure class=""card card-product"">
                        <div class=""img-wrap""><img src=""images/items/2.jpg""> </div>
                        <figcaption class=""info-wrap"">
                            <h4 class=""title"">Good product</h4>
     ");
            WriteLiteral(@"                       <p class=""desc"">Some small description goes here</p>
                            <div class=""rating-wrap"">
                                <ul class=""rating-stars"">
                                    <li style=""width:80%"" class=""stars-active"">
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                </ul>
                                <div class=""label-rating"">132 reviews</div>
                                <div class=""label-rating"">154 orders </div>
                            </div> <!-- rating-wrap.// -->
                        </f");
            WriteLiteral(@"igcaption>
                        <div class=""bottom-wrap"">
                            <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                            <div class=""price-wrap h5"">
                                <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                            </div> <!-- price-wrap.// -->
                        </div> <!-- bottom-wrap.// -->
                    </figure>
                </div> <!-- col // -->
                <div class=""col-md-4"">
                    <figure class=""card card-product"">
                        <div class=""img-wrap""><img src=""images/items/3.jpg""></div>
                        <figcaption class=""info-wrap"">
                            <h4 class=""title"">Product name goes here</h4>
                            <p class=""desc"">Some small description goes here</p>
                            <div class=""rating-wrap"">
                                <ul class=""rating-stars"">
         ");
            WriteLiteral(@"                           <li style=""width:80%"" class=""stars-active"">
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                    </li>
                                </ul>
                                <div class=""label-rating"">132 reviews</div>
                                <div class=""label-rating"">154 orders </div>
                            </div> <!-- rating-wrap.// -->
                        </figcaption>
                        <div class=""bottom-wrap"">
                            <a href="""" class=""btn btn-sm btn-primary float-right"">Order Now</a>
                            <div class=""");
            WriteLiteral(@"price-wrap h5"">
                                <span class=""price-new"">$1280</span> <del class=""price-old"">$1980</del>
                            </div> <!-- price-wrap.// -->
                        </div> <!-- bottom-wrap.// -->
                    </figure>
                </div> <!-- col // -->
            </div> <!-- row.// -->
        </div>


");
            EndContext();
#line 163 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
          
            /*
            Razor - Motor template do ASP.NET
            */

            /*
            URL : #Fragmento (tipo Âncora)
            primeiro  @using (Html.BeginForm("index", "home", FormMethod.Post))
            */

        

#line default
#line hidden
            BeginContext(9927, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 175 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
         using (Html.BeginForm(null, null, null, FormMethod.Post, false, new { @action = @Url.Action("index,home") + "#formulario" }))
        {



#line default
#line hidden
            BeginContext(10080, 302, true);
            WriteLiteral(@"            <div class=""jumbotron jumbotron-fluid container background-color: rgb(238, 238, 238);"" style=""background-color: rgb(255, 255, 255)"">
                <div class=""container"" id=""formulario"">
                    <div class=""row"">
                        <div class=""col-sm-8 offset-sm-2"">
");
            EndContext();
#line 183 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
                             if (TempData["MSG_S"] != null)
                            {

#line default
#line hidden
            BeginContext(10474, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(10538, 17, false);
#line 185 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
                                                          Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(10555, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 186 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(10592, 725, true);
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-6 offset-sm-2"">
                            <div class=""form-group"">
                                <label for=""nome"" style=""font-size: larger; color: rgb(0, 0, 0);"">Faz seu cadastro pra receber as melhores ofertas do LojaVirtual antes de todo mundo!</label>
                                <div class=""input-group"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text""><i class=""fa fa-envelope""></i></span>
                                    </div>
                                    ");
            EndContext();
            BeginContext(11318, 86, false);
#line 197 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
                               Write(Html.EditorFor(x => x.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(11404, 280, true);
            WriteLiteral(@"
                                    <!--   <input type=""text"" class=""form-control"" name=""nome"" id=""nome"" placeholder=""""
                                required="""" value=""""> -->
                                </div>
                                <span style=""color: red;"">");
            EndContext();
            BeginContext(11685, 39, false);
#line 201 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
                                                     Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(11724, 403, true);
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-sm-2"">
                            <br />
                            <button class=""subscribe btn btn-primary btn-block"" type=""submit"" style=""margin-top:37px"">Cadastrar</button>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 211 "C:\Users\rolim\Desktop\ASP.NET-Core-2.2---Loja-Virtual\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(12138, 124, true);
            WriteLiteral("\r\n    <div class=\"jumbotron jumbotron-fluid\" style=\" background-color: rgb(238, 238, 238)\">\r\n    </div>\r\n\r\n    </main>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.NewsletterEmail> Html { get; private set; }
    }
}
#pragma warning restore 1591

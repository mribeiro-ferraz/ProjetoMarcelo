#pragma checksum "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4faf34481a2a49bc14d4ac9396eb3e8ca720a9dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Lista.cshtml", typeof(AspNetCore.Views_Home_Lista))]
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
#line 1 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\_ViewImports.cshtml"
using niverTchelo;

#line default
#line hidden
#line 2 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\_ViewImports.cshtml"
using niverTchelo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4faf34481a2a49bc14d4ac9396eb3e8ca720a9dc", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1349897273fbb9b63e1f27332fe859fb95e6bb49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<niverTchelo.Models.Convidados>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
  
    ViewData["Title"] = "Lista de Convidados";

#line default
#line hidden
            BeginContext(108, 279, true);
            WriteLiteral(@"
<div class=""pt-6"">
    <div class=""card container col-md-10 col-sm-10 col-lg-10"">
        <div class=""card-header card-header-info"">
            <h4 class=""card-title "">Lista de Convidados</h4>
            <p class=""card-category"" style=""float: right; "">Total Confirmados: ");
            EndContext();
            BeginContext(388, 13, false);
#line 11 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                                                                          Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(401, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
            BeginContext(466, 255, true);
            WriteLiteral("        </div>\r\n        <div class=\"card-body col-md-12 col-sm-12 col-lg-12\">\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table\">\r\n\r\n                    <thead>\r\n                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(722, 40, false);
#line 20 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(762, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(802, 39, false);
#line 21 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(841, 59, true);
            WriteLiteral("</th>\r\n                            <th class=\"text-center\">");
            EndContext();
            BeginContext(901, 44, false);
#line 22 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Mensagem));

#line default
#line hidden
            EndContext();
            BeginContext(945, 97, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 26 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                         foreach (var convidados in Model)
                        {

#line default
#line hidden
            BeginContext(1129, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1200, 41, false);
#line 29 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                               Write(Html.DisplayFor(model => convidados.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1285, 40, false);
#line 30 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                               Write(Html.DisplayFor(model => convidados.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1369, 45, false);
#line 31 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                               Write(Html.DisplayFor(model => convidados.Mensagem));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 33 "C:\Workspace\Projeto\niverTchelo\niverTchelo\Views\Home\Lista.cshtml"
                        }

#line default
#line hidden
            BeginContext(1483, 110, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<niverTchelo.Models.Convidados>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d29ec1530d0836917687be1fa31bea2545134b92"
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
#line 1 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#line 2 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\_ViewImports.cshtml"
using Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29ec1530d0836917687be1fa31bea2545134b92", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(76, 294, true);
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">Tarefas a fazer</div>
    <div class=""card-body"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Tarefa</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 16 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
            BeginContext(434, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(489, 11, false);
#line 19 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml"
                       Write(item.Tarefa);

#line default
#line hidden
            EndContext();
            BeginContext(500, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 21 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(553, 50, true);
            WriteLiteral("            </tbody>  \r\n        </table>\r\n        ");
            EndContext();
            BeginContext(604, 107, false);
#line 24 "C:\Users\vinic\OneDrive\Documentos\GitHub\aula_dotnet\Application\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Cadastrar Tarefa", "Cadastrar", "Home", null, new { @class="btn btn-success btn-sm mt-5"}));

#line default
#line hidden
            EndContext();
            BeginContext(711, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591

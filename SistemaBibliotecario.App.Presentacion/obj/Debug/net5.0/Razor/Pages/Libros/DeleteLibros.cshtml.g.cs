#pragma checksum "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c17197582992604bcfd596bdbb514f344080ff5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SistemaBibliotecario.App.Presentacion.Pages.Libros.Pages_Libros_DeleteLibros), @"mvc.1.0.razor-page", @"/Pages/Libros/DeleteLibros.cshtml")]
namespace SistemaBibliotecario.App.Presentacion.Pages.Libros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\_ViewImports.cshtml"
using SistemaBibliotecario.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c17197582992604bcfd596bdbb514f344080ff5e", @"/Pages/Libros/DeleteLibros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6569c659545d2f48c5c80c9822b58766a80e8485", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Libros_DeleteLibros : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListLibros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Datos Detallados del libro ");
#nullable restore
#line 6 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
                          Write(Model.libro.lib_titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c17197582992604bcfd596bdbb514f344080ff5e5164", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c17197582992604bcfd596bdbb514f344080ff5e5426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 8 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.libro.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        Id en base de datos: ");
#nullable restore
#line 10 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
                        Write(Model.libro.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Titulo: ");
#nullable restore
#line 13 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
           Write(Model.libro.lib_titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ISBN: ");
#nullable restore
#line 16 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
         Write(Model.libro.lib_isbn);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Sinopsis: ");
#nullable restore
#line 19 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
             Write(Model.libro.lib_sinopsis);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Numero de capitulos: ");
#nullable restore
#line 22 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
                        Write(Model.libro.lib_numCapt);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Numero de páginas: ");
#nullable restore
#line 25 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
                      Write(Model.libro.lib_numPag);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Tipo de libro: ");
#nullable restore
#line 28 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
                  Write(Model.libro.lib_tipoLibroid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Idioma: ");
#nullable restore
#line 31 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
           Write(Model.libro.lib_idioLibroid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Categoria: ");
#nullable restore
#line 34 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
              Write(Model.libro.lib_catLibroid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Autor: ");
#nullable restore
#line 37 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
          Write(Model.libro.lib_autid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Editorial: ");
#nullable restore
#line 40 "C:\Users\Nicolas\Documents\MinTic\Ciclo III\Programacion\SistemaBibliotecario\SistemaBibliotecario.App.Presentacion\Pages\Libros\DeleteLibros.cshtml"
              Write(Model.libro.lib_editid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    \r\n    <button type=\"submit\" class=\"btn btn-success\">Eliminar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c17197582992604bcfd596bdbb514f344080ff5e12695", async() => {
                WriteLiteral("Volver a la Lista de libros... ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SitemaBibliotecario.App.Presentacion.Pages.DeleteLibrosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SitemaBibliotecario.App.Presentacion.Pages.DeleteLibrosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SitemaBibliotecario.App.Presentacion.Pages.DeleteLibrosModel>)PageContext?.ViewData;
        public SitemaBibliotecario.App.Presentacion.Pages.DeleteLibrosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

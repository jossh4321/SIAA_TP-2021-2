#pragma checksum "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Catalogo\_EditProductInCatalogo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845944bf4b163aa793a9b4169e48c097ab14112c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo__EditProductInCatalogo), @"mvc.1.0.view", @"/Views/Catalogo/_EditProductInCatalogo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\_ViewImports.cshtml"
using SIGECA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\_ViewImports.cshtml"
using SIGECA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845944bf4b163aa793a9b4169e48c097ab14112c", @"/Views/Catalogo/_EditProductInCatalogo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4ab52cd751c53f6be13bb5678f5ae7697ae785", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo__EditProductInCatalogo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""modificarProducto"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog @*modal-lg*@ modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""registrarProductoLabel"">Modificar Producto en Catálogo</h5>
                <button type=""button"" class=""close"" data-bs-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""accordion"" id=""accordionExample"">
                    <div class=""card"">
                        <div class=""card-header"" id=""headingOne"">
                            <h2 class=""mb-0"">
                                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""");
            WriteLiteral(@"collapseOne"">
                                    Modificar en Catálogo
                                </button>
                            </h2>
                        </div>
                        <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""mb-3 col-6"">
                                        <label for=""precio"" class=""form-label"">Stock Disponible: </label>
                                        <input class=""form-control"" id=""precioConsultar"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""headingOne"">
                            <h2 class=""mb-0"">
           ");
            WriteLiteral(@"                     <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                    Modificar Oferta
                                </button>
                            </h2>
                        </div>
                        <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""mb-3 col-6"">
                                        <label for=""nombre"" class=""form-label"">Fecha de Inicio:</label>
                                        <input class=""form-control"" id=""nombreConsultar"">
                                    </div>
                                    <div class=""mb-3 col-6"">
                                        <label for=""precio"" class=""form-label"">Fecha de Vencimiento:<");
            WriteLiteral(@"/label>
                                        <input class=""form-control"" id=""precioConsultar"">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""mb-3 col-6"">
                                        <label for=""nombre"" class=""form-label"">Descuento(%): </label>
                                        <input class=""form-control"" id=""nombreConsultar"">
                                    </div>
                                    <div class=""mb-3 col-6"">
                                        <label for=""precio"" class=""form-label"">Stock Oferta:</label>
                                        <input class=""form-control"" id=""precioConsultar"">
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""mb-3 col-6"">
                                     ");
            WriteLiteral(@"   <label for=""nombre"" class=""form-label"">Tienda: </label>
                                        <select class=""form-control"" id=""nombreConsultar""></select>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-outline-danger"" data-bs-dismiss=""modal"">Cerrar</button>
                <button type=""button"" class=""btn btn-success"">Modificar</button>
            </div>
        </div>
    </div>
</div>");
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
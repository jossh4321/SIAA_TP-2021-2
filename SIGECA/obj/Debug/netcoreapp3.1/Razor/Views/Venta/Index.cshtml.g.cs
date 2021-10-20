#pragma checksum "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc07fd71063966968845c1a1e63cf8634ebacc90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_Index), @"mvc.1.0.view", @"/Views/Venta/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc07fd71063966968845c1a1e63cf8634ebacc90", @"/Views/Venta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4ab52cd751c53f6be13bb5678f5ae7697ae785", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SIGECA.Controllers.VentaController.ModelVenta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/html5-qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Venta/GestionarVenta.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Venta/Validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
  
    ViewData["Title"] = "Gestionar Ventas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""mt-3"" style=""color:white"">Gestion de Ventas</h2>
<div class=""row"">
    <div class=""col"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"" style=""border-radius:10px"">
                <p style=""color:black;"">Existen ");
#nullable restore
#line 11 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                                           Write(Model.ventas.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ventas registradas</p>
            </ol>
        </nav>
    </div>
    <div class=""col"">
        <button class=""btn btn-primary float-right"" onclick=""clearDataVenta(); $('#modalRegistrarVenta').modal('show')""><i class=""fas fa-plus""></i> Agregar Venta</button>
    </div>
</div>



<table id=""tableVenta"" class=""table datatable-venta"" style=""background-color:white"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Codigo de Venta</th>
            <th scope=""col"">Costo</th>
            <th scope=""col"">Fecha Registro</th>
            <th scope=""col"">Estado</th>
            <th scope=""col"">Acciones</th>
        </tr>
    </thead>
</table>

<div class=""modal"" id=""modalRegistrarVenta"" tabindex=""-1"" aria-labelledby=""registrarVentaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""registrarUsuarioLabel"">Registrar Nueva Venta</h5>
    ");
            WriteLiteral(@"            <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""cerrarModal(); $('#modalRegistrarVenta').modal('hide')"" aria-label=""Close"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"" style=""padding: 5px 5%; margin-top: 30px;"">
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <label class=""form-label"">Tipo de Venta: </label>
                    </div>
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""presencialRadio"" value=""presencial"" name=""customRadioInline1"" class=""custom-control-input"">
                            <label class=""custom-control-label"" for=""presencialRadio"">Presencial</label>
                        </div>
                    </div>
                 ");
            WriteLiteral(@"   <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""onlineRadio"" value=""online"" name=""customRadioInline1"" class=""custom-control-input"">
                            <label class=""custom-control-label"" for=""onlineRadio"">Online</label>
                        </div>
                    </div>
                </div>
                <div id=""clienteForm"" class=""row"" style=""padding: 5px 5%"">
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""nombreCliente"" class=""form-label"">Nombre del Cliente: </label>
                        <input class=""form-control"" type=""text"" id=""nombreCliente"" name=""nombreCliente"" />
                    </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""apellidoCliente"" class=""form-label"">Apellidos del Cliente: </label>
            ");
            WriteLiteral(@"            <input class=""form-control"" type=""text"" id=""apellidoCliente"" name=""dniCliente"" />
                    </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""correoCliente"" class=""form-label"">Correo: </label>
                        <input class=""form-control"" type=""text"" id=""correoCliente"" name=""dniCliente"" />
                    </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""telefonoCliente"" class=""form-label"">Telefono: </label>
                        <input class=""form-control"" type=""text"" id=""telefonoCliente"" name=""dniCliente"" maxlength=""9"" />
                    </div>
                    <div class=""col-12 col-sm-12 col-lg-12 col-xl-12"">
                        <label for=""direccionCliente"" class=""form-label"" style="" margin-top: 9px;"">Direccion:</label>
                        <textarea class=""form-control"" id=""direccionCliente""
                                  ");
            WriteLiteral(@"name=""direccionCliente""
                                  rows=""3""></textarea>
                    </div>
                </div>
                <hr />
                <div class=""row"" style=""padding: 5px 5%"">

                    <div>
                        <div id=""qr-reader"" style=""width:500px""></div>
                        <div id=""qr-reader-results""></div>
                    </div>

                    <div class=""col-6 col-sm-4"">
                        <label for=""producto"" class=""form-label"">Producto: </label>
                        <select class=""form-select form-control"" onchange=""cambioProductoRegistrar();"" id=""productoVentaRegistrar"" name=""producto"">
");
#nullable restore
#line 96 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                             foreach (var producto in Model.productos)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc07fd71063966968845c1a1e63cf8634ebacc9010523", async() => {
#nullable restore
#line 98 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                                                                 Write(producto.nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                                            WriteLiteral(producto.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-6 col-sm-2"">
                        <label for=""cantidadItem"" class=""form-label"">Cantidad:</label>
                        <input class=""form-control"" id=""cantidadVentaRegistrar"" onblur=""cambioCantidadRegistrar();"" name=""cantidadItem"">
                    </div>
                    <div class=""col-6 col-sm-2"">
                        <label for=""costoItem"" class=""form-label"">Costo:</label>
                        <input class=""form-control"" id=""costoVentaRegistrar"" name=""costoItem"" disabled>
                    </div>
                    <div class=""col-6 col-sm-1"" style=""display:flex"">
                        <a class=""btn btn-primary"" id=""agregaritemVenta"" onclick=""addItem();"" style=""align-self:flex-end""><i class=""fas fa-plus""></i></a>
                    </div>
                </div>
                <hr />
                <table id=""itemVenta"" class=""table"">
                    <thead class=""th");
            WriteLiteral(@"ead-light"">
                        <tr>
                            <th scope=""col"">Nombre del producto</th>
                            <th scope=""col"">Cantidad</th>
                            <th scope=""col"">Costo</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
                <br />
                <div style=""text-align: right"">
                    <h2>Total: S/. <span id=""itemRegistrarTotal"">0.00</span></h2>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"" style=""padding: 5px 5%;width:100%"">
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <button type=""button"" onclick=""cerrarModal(); $('#modalRegistrarVenta').modal('hide')"" class=""btn btn-block btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                    </div>
        ");
            WriteLiteral(@"            <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <button type=""button"" class=""btn btn-block btn-primary"" id=""btnRegistrarVentaModal"">
                            Registrar Venta
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" id=""modalModificarVenta"" tabindex=""-1"" aria-labelledby=""modificarVentaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modificarCompraLabel"">Modificar Venta</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""cerrarModal(); $('#modalModificarVenta').modal('hide')"" aria-label=""Close"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"" style=""padding");
            WriteLiteral(@": 5px 5%; margin-top: 30px;"">
                    <input type=""hidden"" id=""idVentaModificar"" name=""id"" />
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <label class=""form-label"">Tipo de Venta: </label>
                    </div>
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""presencialRadioModificar"" value=""presencial"" name=""customRadioInline3"" class=""custom-control-input"">
                            <label class=""custom-control-label"" for=""presencialRadioModificar"">Presencial</label>
                        </div>
                    </div>
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""onlineRadioModificar"" value=""online"" name=""customR");
            WriteLiteral(@"adioInline3"" class=""custom-control-input"">
                            <label class=""custom-control-label"" for=""onlineRadioModificar"">Online</label>
                        </div>
                    </div>
                </div>
                <hr />
                <div class=""row"" style=""padding: 5px 5%"">
                    <div class=""col-6 col-sm-4"">
                        <label for=""producto"" class=""form-label"">Producto: </label>
                        <select class=""form-select form-control"" id=""productoVentaModificar"" onchange=""cambioProductoModificar();"" name=""producto"" aria-label=""Default select example"">
");
#nullable restore
#line 181 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                             foreach (var producto in Model.productos)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc07fd71063966968845c1a1e63cf8634ebacc9018266", async() => {
#nullable restore
#line 183 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                                                                 Write(producto.nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                                            WriteLiteral(producto.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 184 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-6 col-sm-2"">
                        <label for=""cantidadItem"" class=""form-label"">Cantidad:</label>
                        <input class=""form-control"" id=""cantidadVentaModificar"" onblur=""cambioCantidadModificar();"" name=""cantidadItem"">
                    </div>
                    <div class=""col-6 col-sm-2"">
                        <label for=""costoItem"" class=""form-label"">Costo:</label>
                        <input class=""form-control"" id=""costoVentaModificar"" name=""costoItem"" disabled>
                    </div>
                    <div class=""col-6 col-sm-1"" style=""display:flex"">
                        <a class=""btn btn-primary"" id=""agregaritemVenta"" onclick=""addItemModificar();"" style=""align-self:flex-end""><i class=""fas fa-plus""></i></a>
                    </div>
                </div>
                <hr />
                <table id=""itemVentaModificar"" class=""table"">
                  ");
            WriteLiteral(@"  <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Nombre del producto</th>
                            <th scope=""col"">Cantidad</th>
                            <th scope=""col"">Costo</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
                <br />
                <div style=""text-align: right"">
                    <h2>Total: S/. <span id=""itemModificarTotal"">0.00</span></h2>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"" style=""padding: 5px 5%;width:100%"">
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <button type=""button"" onclick=""cerrarModal(); $('#modalModificarVenta').modal('hide')"" class=""btn btn-block btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                  ");
            WriteLiteral(@"  </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <button type=""button"" class=""btn btn-block btn-primary"" id=""btnModificarVentaModal"">
                            Modificar Venta
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" id=""modalConsultarVenta"" tabindex=""-1"" aria-labelledby=""consultarVentaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modificarCompraLabel"">Detalle de Venta</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""$('#modalConsultarVenta').modal('hide')"" aria-label=""Close"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"" style=""pad");
            WriteLiteral(@"ding: 5px 5%; margin-top: 30px;"">
                    <input type=""hidden"" id=""idVentaConsultar"" name=""id"" />
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <label class=""form-label"">Tipo de Venta: </label>
                    </div>
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""presencialRadioConsultar"" value=""presencial"" name=""customRadioInline5"" class=""custom-control-input"" disabled>
                            <label class=""custom-control-label"" for=""presencialRadioConsultar"">Presencial</label>
                        </div>
                    </div>
                    <div class=""col-3 col-sm-3 col-lg-3 col-xl-3"">
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" id=""onlineRadioConsultar"" value=""online"" ");
            WriteLiteral(@"name=""customRadioInline5"" class=""custom-control-input"" disabled>
                            <label class=""custom-control-label"" for=""onlineRadioConsultar"">Online</label>
                        </div>
                    </div>
                </div>
                <div id=""clienteFormConsultar"" class=""row"" style=""padding: 5px 5%"">
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""nombreClienteConsultar"" class=""form-label"">Nombre del Cliente: </label>
                        <input class=""form-control"" type=""text"" id=""nombreClienteConsultar"" name=""nombreClienteConsultar"" disabled />
                    </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""apellidoClienteConsultar"" class=""form-label"">Apellidos del Cliente: </label>
                        <input class=""form-control"" type=""text"" id=""apellidoClienteConsultar"" name=""dniClienteConsultar"" disabled />
                    </div>");
            WriteLiteral(@"
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""correoClienteConsultar"" class=""form-label"">Correo: </label>
                        <input class=""form-control"" type=""text"" id=""correoClienteConsultar"" name=""dniClienteConsultar"" disabled />
                    </div>
                    <div class=""col-6 col-sm-6 col-lg-6 col-xl-6"">
                        <label for=""telefonoClienteConsultar"" class=""form-label"">Telefono: </label>
                        <input class=""form-control"" type=""text"" id=""telefonoClienteConsultar"" name=""dniClienteConsultar"" disabled />
                    </div>
                    <div class=""col-12 col-sm-12 col-lg-12 col-xl-12"">
                        <label for=""direccionClienteConsultar"" class=""form-label"" style="" margin-top: 9px;"">Direccion:</label>
                        <textarea class=""form-control"" id=""direccionClienteConsultar""
                                  name=""direccionCliente""
                    ");
            WriteLiteral(@"              rows=""3""></textarea>
                    </div>
                </div>
                <div class=""row"" style=""padding: 5px 5%; margin-top: 30px;"">
                    
                </div>
                <hr />
                <table id=""itemVentaConsultar"" class=""table"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Nombre del producto</th>
                            <th scope=""col"">Cantidad</th>
                            <th scope=""col"">Costo</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
                <br />
                <div style=""text-align: right"">
                    <h2>Total: S/. <span id=""itemConsultarTotal"">0.00</span></h2>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""$('#modalConsultarVenta').mo");
            WriteLiteral("dal(\'hide\')\" class=\"btn btn-block btn-secondary\" data-dismiss=\"modal\">Cerrar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"hidden\" id=\"URL_ObtenerVentaPorID\"");
            BeginWriteAttribute("value", " value=\"", 17726, "\"", 17772, 1);
#nullable restore
#line 312 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 17734, Url.Action("ObtenerVentaID", "Venta"), 17734, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"URL_VentasListarTodos\"");
            BeginWriteAttribute("value", " value=\"", 17825, "\"", 17870, 1);
#nullable restore
#line 313 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 17833, Url.Action("ObtenerVentas", "Venta"), 17833, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"URL_ObtenerProductoPorID\"");
            BeginWriteAttribute("value", " value=\"", 17926, "\"", 17981, 1);
#nullable restore
#line 314 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 17934, Url.Action("ObtenerProductoPorId", "Producto"), 17934, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"URL_VentaActualizarEstado\"");
            BeginWriteAttribute("value", " value=\"", 18038, "\"", 18088, 1);
#nullable restore
#line 315 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 18046, Url.Action("CambiarEstadoVenta", "Venta"), 18046, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"URL_ObtenerUsuario\"");
            BeginWriteAttribute("value", " value=\"", 18138, "\"", 18184, 1);
#nullable restore
#line 316 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 18146, Url.Action("ObtenerUsuario", "Venta"), 18146, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"URL_ObtenerProductoPorID\"");
            BeginWriteAttribute("value", " value=\"", 18240, "\"", 18295, 1);
#nullable restore
#line 317 "C:\Users\USER\Desktop\SIAC_TP\SIAA_TP-2021-2\SIGECA\Views\Venta\Index.cshtml"
WriteAttributeValue("", 18248, Url.Action("ObtenerProductoPorId", "Producto"), 18248, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc07fd71063966968845c1a1e63cf8634ebacc9031303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc07fd71063966968845c1a1e63cf8634ebacc9032403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc07fd71063966968845c1a1e63cf8634ebacc9033503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SIGECA.Controllers.VentaController.ModelVenta> Html { get; private set; }
    }
}
#pragma warning restore 1591
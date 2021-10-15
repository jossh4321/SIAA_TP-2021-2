﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIGECA.Entities;
using SIGECA.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGECA.Controllers
{
    public class VentaController : Controller
    {
        private readonly VentaService _ventaService;
        private readonly ProductoService _productoService;
        public VentaController(VentaService ventaService, ProductoService productoService, UsuarioService usuarioService)
        {
            _ventaService = ventaService;
            _productoService = productoService;
        }
        public async Task<IActionResult> Index()
        {
            ModelVenta model = new ModelVenta();
            model.ventas = await _ventaService.GetAll();
            model.productos = await _productoService.GetAll();
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult<List<Compra>>> ObtenerVentas()
        {
            List<Venta> ventas = await _ventaService.GetAll();
            return Json(new { recordsFiltered = ventas.Count, recordsTotal = ventas.Count, data = ventas });
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarVenta([FromBody] Venta venta)
        {
            List<Producto> productos = await _productoService.GetAll();
            List<Venta> ventas = await _ventaService.GetAll();
            int record = ventas.Count;
            string codigo = "V-" + Convert.ToString(record + 1).PadLeft(6,'0');
            venta.codigoVenta = codigo;
            Object result = null;
            try
            {
                venta.fechaVenta = DateTime.Now;
                foreach (Items item in venta.items)
                {
                    var itm = productos.Find(i => i.nombre == item.nombre);
                    item.productoID = itm.id;
                    int stockUpdated = productos.Find(i => i.id == item.productoID).stock - item.cantidad;
                    _productoService.UpdateProductoStock(item.productoID, stockUpdated);
                }

                venta = (Venta)await _ventaService.CreateVenta(venta);
                result = new { result = "success", title = "Satisfactorio", message = "Venta Registrado Correctamente", url = "Venta/Registro" };
                return Content(JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                result = new { result = "error", title = "Error", message = "Lo sentimos, hubo un problema no esperado. Vuelva a intentar por favor. " + ex.Message, url = "" };
                return Content(JsonConvert.SerializeObject(result));
            }
        }
        [HttpPost]
        public async Task<ActionResult> ObtenerVentaID(string idventa)
        {
            Object result = null;
            Venta venta = await _ventaService.GetById(idventa);
            List<Producto> productos = await _productoService.GetAll();
            foreach (Items item in venta.items)
            {
                var itm = productos.Find(i => i.id == item.productoID);
                    item.nombre = itm.nombre;
            }
            result = new { result = "success", title = "Satisfactorio", value = new { venta } , url = "Compra/Consultar" };
            return Content(JsonConvert.SerializeObject(result));
        }
        [HttpPost]
        public async Task<ActionResult> ActualizarVenta([FromBody] Venta venta)
        {
            List<Producto> productos = await _productoService.GetAll();
            Object result = null;
            foreach (Items item in venta.items)
            {
                var itm = productos.Find(i => i.nombre == item.nombre);
                item.productoID = itm.id;
            }
            Venta ventaActualizado = await _ventaService.UpdateVenta(venta);
            result = new { result = "success", title = "Satisfactorio", value = ventaActualizado, url = "Compra/ActualizarUsuario" };
            return Content(JsonConvert.SerializeObject(result));
        }
        [HttpPost]
        public async Task<ActionResult> CambiarEstadoVenta(string ventaid, string estadoActual)
        {
            Object result = null;
            await _ventaService.UpdateEstadoVenta(ventaid, estadoActual);
            result = new { result = "success", title = "Satisfactorio", url = "Venta/ActualizarVenta" };
            return Content(JsonConvert.SerializeObject(result));
        }
        public class ModelVenta
        {
            public IEnumerable<Venta> ventas { get; set; }
            public IEnumerable<Producto> productos { get; set; }
        }
    }
}

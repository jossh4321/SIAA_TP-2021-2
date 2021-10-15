﻿using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Driver;
using SIGECA.DTOs;
using SIGECA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGECA.Services
{
    public class ProductoService
    {
        private readonly IMongoCollection<Producto> _producto;
        private readonly IMongoCollection<Categoria> _categoria;
        private readonly IMongoCollection<Inventario> _inventario;

        public ProductoService(ISigecaDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _producto = database.GetCollection<Producto>("Producto");
            _categoria = database.GetCollection<Categoria>("Categoria");
            _inventario = database.GetCollection<Inventario>("Inventario");
        }

        public async Task<List<Producto>> Get()
        {
            return await _producto.Find(x => true).ToListAsync();
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _producto.FindAsync(x => true).Result.ToListAsync();
        }

        public async Task<Producto> GetById(string productoID)
        {
            return await _producto.Find(x => x.id == productoID).FirstOrDefaultAsync();
        }

        public async Task<List<Producto>> GetByCategoriaId(string categoriaID)
        {
            return await _producto.Find(x => x.categoriaID == categoriaID).ToListAsync();
        }

        public async Task Create(Producto producto)
        {
            await _producto.InsertOneAsync(producto);
        }

        public async Task Update(Producto producto)
        {
            var old = Builders<Producto>.Filter.Eq(s => s.id, producto.id);
            await _producto.ReplaceOneAsync(old, producto);
        }

        public async Task UpdateById(string _id, Producto producto)
        {
            await _producto.ReplaceOneAsync(old => old.id == _id, producto);
        }

        public async Task Delete(Producto producto)
        {
            await _producto.DeleteOneAsync(old => old.id == producto.id);
        }

        public async Task DeleteById(string _id)
        {
            await _producto.DeleteOneAsync(old => old.id == _id);
        }

        public async Task<List<Categoria>> GetAllCategoriaProducto()
        {
            return await _categoria.Find(x => true).ToListAsync();
        }

        public async Task<Categoria> GetCategoryNameByID(string CategodyId)
        {
            return await _categoria.FindAsync(x => x.id == CategodyId).Result.FirstOrDefaultAsync();
        }

        public async Task<List<ProductoDTO>> GetAllProductoDTO()
        {
            List<ProductoDTO> productos = new List<ProductoDTO>();
            var lookup = new BsonDocument("$lookup",
                                            new BsonDocument
                                                {
                                                    { "from", "Categoria" },
                                                    { "let",
                                            new BsonDocument("catProdID", "$categoriaID") },
                                                    { "pipeline",
                                            new BsonArray
                                                    {
                                                        new BsonDocument("$match",
                                                        new BsonDocument("$expr",
                                                        new BsonDocument("$eq",
                                                        new BsonArray
                                                                    {
                                                                        new BsonDocument("$toObjectId", "$$catProdID"),
                                                                        "$_id"
                                                                    })))
                                                    } },
                                                    { "as", "CategoriaProducto" }
                                                });
            var project = new BsonDocument("$project",
                                 new BsonDocument
                                     {
                                        { "_id", "$_id" },
                                        { "categoria",
                                new BsonDocument("$arrayElemAt",
                                new BsonArray
                                            {
                                                "$CategoriaProducto",
                                                0
                                            }) },
                                        { "nombre", "$nombre" },
                                        { "descripcion", "$descripcion" },
                                        { "tipoVenta", "$tipoVenta" },
                                        { "unidadMedida", "$unidadMedida" },
                                        { "precio", "$precio" },
                                        { "stock", "$stock" },
                                        { "urlImagen", "$urlImagen" },
                                        { "codigoQR", "$codigoQR" }
                                     });

            productos = await _producto.Aggregate()
                .AppendStage<dynamic>(lookup)
                .AppendStage<ProductoDTO>(project)
                .ToListAsync();

            return productos;
        }
        public async Task<Producto> CreateProducto(Producto producto)
        {
            _producto.InsertOne(producto);
            return producto;
        }

        public async Task<Producto> CreateProducto(Producto producto, String usuario)
        {
            _producto.InsertOne(producto);
            Inventario inventarioProducto = new Inventario();
            inventarioProducto.productoID = producto.id;
            inventarioProducto.tiendaID = "60bd45c242990c144885550f";
            inventarioProducto.usuarioId = usuario;
            inventarioProducto.fechaFinal = DateTime.Now;
            inventarioProducto.fechaInicial = DateTime.Now;
            _inventario.InsertOne(inventarioProducto);
            return producto;
        }

        public async Task<Producto> UpdateProducto(Producto producto)
        {

            var update = Builders<Producto>.Update.Set("nombre", producto.nombre)
                                           .Set("categoriaID", producto.categoriaID)
                                           .Set("descripcion", producto.descripcion)
                                           .Set("tipoVenta", producto.tipoVenta)
                                           .Set("precio", producto.precio)
                                           .Set("unidadMedida", producto.unidadMedida)
                                           .Set("stock", producto.stock);
            var filters = Builders<Producto>.Filter.Eq("id", producto.id);
            _producto.UpdateOne(filters, update);
            return producto;
        }
        public async Task<string> UpdateProductoStock(string productoID, int stockProducto)
        {

            var update = Builders<Producto>.Update.Set("stock", stockProducto);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);

            return productoID;
        }


        public async Task<string> UpdateProductoStockInicial(string productoID, int stockProducto)
        {

            var update = Builders<Producto>.Update.Set("stock", stockProducto);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);

            var updateInv = Builders<Inventario>.Update.Set("stockInicial", stockProducto)
                .Set("fechaInicial", DateTime.Now);
            var filtersInv = Builders<Inventario>.Filter.Eq("productoID", productoID);
            _inventario.UpdateOne(filtersInv, updateInv);

            return productoID;
        }

        public async Task<string> UpdateProductoStockFinal(string productoID, int stockProducto)
        {

            var update = Builders<Producto>.Update.Set("stock", stockProducto);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);

            var updateInv = Builders<Inventario>.Update.Set("stockFinal", stockProducto)
                .Set("fechaFinal", DateTime.Now);
            var filtersInv = Builders<Inventario>.Filter.Eq("productoID", productoID);
            _inventario.UpdateOne(filtersInv, updateInv);

            return productoID;
        }


        public async Task<Producto> UpdateProductoPrecio(Producto producto)
        {

            var update = Builders<Producto>.Update.Set("precio", producto.precio);
            var filters = Builders<Producto>.Filter.Eq("id", producto.id);
            _producto.UpdateOne(filters, update);
            return producto;
        }

        public async Task<string> UpdateProductoImagen(string imagenProducto, string productoID)
        {

            var update = Builders<Producto>.Update.Set("urlImagen", imagenProducto);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);
            return imagenProducto;
        }

        public async Task<string> UpdateProductoImagenYQRCodigo(string productoID, string urlImagen, string codigoQR)
        {

            var update = Builders<Producto>.Update.Set("urlImagen", urlImagen)
                                                  .Set("codigoQR", codigoQR);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);
            return productoID;
        }
        public async Task<string> UpdateProductoQRCodigo(string productoID, string codigoQR)
        {
            var update = Builders<Producto>.Update.Set("codigoQR", codigoQR);
            var filters = Builders<Producto>.Filter.Eq("id", productoID);
            _producto.UpdateOne(filters, update);
            return productoID;
        }

        public async Task<List<ProductoOfertaDTO>> ObtenerProductoOfertaPorTienda(string productoID)
        {
            List<ProductoOfertaDTO> listaProductoOderta = new List<ProductoOfertaDTO>();
            var _match = new BsonDocument("$match",
                        new BsonDocument("_id",
                        new ObjectId(productoID)));
            var _lookupOferta = new BsonDocument("$lookup",
                                    new BsonDocument
                                        {
                                            { "from", "Oferta" },
                                            { "let",
                                    new BsonDocument("prodid", "$_id") },
                                            { "pipeline",
                                    new BsonArray
                                            {
                                                new BsonDocument("$match",
                                                new BsonDocument("$expr",
                                                new BsonDocument("$and",
                                                new BsonArray
                                                            {
                                                                "$$prodid",
                                                                new BsonDocument("$toObjectId", "$productoID")
                                                            })))
                                            } },
                                            { "as", "oferta" }
                                        });
            var _unwindOferta = new BsonDocument("$unwind",
                                    new BsonDocument
                                        {
                                            { "path", "$oferta" },
                                            { "preserveNullAndEmptyArrays", false }
                                        });
            var _lookTienda = new BsonDocument("$lookup",
                                    new BsonDocument
                                        {
                                            { "from", "Tienda" },
                                            { "let",
                                    new BsonDocument("tiendaid", "$oferta.tiendaID") },
                                            { "pipeline",
                                    new BsonArray
                                            {
                                                new BsonDocument("$match",
                                                new BsonDocument("$expr",
                                                new BsonDocument("$and",
                                                new BsonArray
                                                            {
                                                                new BsonDocument("$toObjectId", "$$tiendaid"),
                                                                "$_id"
                                                            })))
                                            } },
                                            { "as", "tienda" }
                                        });
            var _unwindTienda = new BsonDocument("$unwind",
                                    new BsonDocument
                                        {
                                            { "path", "$tienda" },
                                            { "preserveNullAndEmptyArrays", false }
                                        });
            var _group1 = new BsonDocument("$group",
                                new BsonDocument
                                    {
                                        { "_id", "$_id" },
                                        { "categoriaID",
                                new BsonDocument("$first", "$categoriaID") },
                                        { "nombre",
                                new BsonDocument("$first", "$nombre") },
                                        { "descripcion",
                                new BsonDocument("$first", "$descripcion") },
                                        { "tipoVenta",
                                new BsonDocument("$first", "$tipoVenta") },
                                        { "unidadMedida",
                                new BsonDocument("$first", "$unidadMedida") },
                                        { "precio",
                                new BsonDocument("$first", "$precio") },
                                        { "stock",
                                new BsonDocument("$first", "$stock") },
                                        { "urlImagen",
                                new BsonDocument("$first", "$urlImagen") },
                                        { "codigoQR",
                                new BsonDocument("$first", "$codigoQR") },
                                        { "tienda",
                                new BsonDocument("$addToSet", "$tienda") },
                                        { "ofertas",
                                new BsonDocument("$addToSet", "$oferta") }
                                    });
            var _unwindTienda2 = new BsonDocument("$unwind",
                                    new BsonDocument("path", "$tienda"));
            var _project = new BsonDocument("$project",
                                    new BsonDocument
                                        {
                                            { "_id", 1 },
                                            { "categoriaID", 1 },
                                            { "nombre", 1 },
                                            { "descripcion", 1 },
                                            { "tipoVenta", 1 },
                                            { "unidadMedida", 1 },
                                            { "precio", 1 },
                                            { "stock", 1 },
                                            { "urlImagen", 1 },
                                            { "codigoQR", 1 },
                                            { "tienda",
                                    new BsonDocument
                                            {
                                                { "_id", 1 },
                                                { "nombre", 1 },
                                                { "ubicacion", 1 },
                                                { "stock", 1 },
                                                { "horarioApertura", 1 },
                                                { "horarioCierre", 1 },
                                                { "trabajadores", 1 },
                                                { "ofertas",
                                    new BsonDocument("$filter",
                                    new BsonDocument
                                                    {
                                                        { "input", "$ofertas" },
                                                        { "as", "oferta" },
                                                        { "cond",
                                    new BsonDocument("$eq",
                                    new BsonArray
                                                            {
                                                                "$$oferta.tiendaID",
                                                                new BsonDocument("$toString", "$tienda._id")
                                                            }) }
                                                    }) }
                                            } }
                                        });
            var _group2 = new BsonDocument("$group",
                            new BsonDocument
                                {
                                    { "_id", "$_id" },
                                    { "categoriaID",
                            new BsonDocument("$first", "$categoriaID") },
                                    { "nombre",
                            new BsonDocument("$first", "$nombre") },
                                    { "descripcion",
                            new BsonDocument("$first", "$descripcion") },
                                    { "tipoVenta",
                            new BsonDocument("$first", "$tipoVenta") },
                                    { "unidadMedida",
                            new BsonDocument("$first", "$unidadMedida") },
                                    { "precio",
                            new BsonDocument("$first", "$precio") },
                                    { "stock",
                            new BsonDocument("$first", "$stock") },
                                    { "urlImagen",
                            new BsonDocument("$first", "$urlImagen") },
                                    { "codigoQR",
                            new BsonDocument("$first", "$codigoQR") },
                                    { "tiendas",
                            new BsonDocument("$addToSet", "$tienda") }
                                });
            listaProductoOderta = await _producto.Aggregate()
                .AppendStage<dynamic>(_match)
                .AppendStage<dynamic>(_lookupOferta)
                .AppendStage<dynamic>(_unwindOferta)
                .AppendStage<dynamic>(_lookTienda)
                .AppendStage<dynamic>(_unwindTienda)
                .AppendStage<dynamic>(_group1)
                .AppendStage<dynamic>(_unwindTienda2)
                .AppendStage<dynamic>(_project)
                .AppendStage<ProductoOfertaDTO>(_group2).ToListAsync();
            return listaProductoOderta;
        }
    }
}

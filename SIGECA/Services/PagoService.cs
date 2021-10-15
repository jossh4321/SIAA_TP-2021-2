﻿using MongoDB.Driver;
using SIGECA.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SIGECA.Services
{
    public class PagoService
    {
        private readonly IMongoCollection<Venta> _ventas;

        public PagoService(ISigecaDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _ventas = database.GetCollection<Venta>("Venta");
        }


        public async Task<List<Venta>> GetAll()
        {
            return _ventas.Find(x => true).ToList();
        }


        public async Task<Venta> GetByCodigoVenta(string codigoVenta)
        {
            return await _ventas.Find(x => x.id == codigoVenta).FirstAsync();
        }
        public async Task updateEstadoVenta(string codigoVenta, string estado)
        {
            var update = Builders<Venta>.Update.Set("estado", estado == "pendiente" ? "cobrado" : "anulada");
            var filters = Builders<Venta>.Filter.Eq("id",codigoVenta);
            _ventas.UpdateOne(filters, update);

        }

    }
}

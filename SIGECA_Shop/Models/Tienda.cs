using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGECA_Shop.Models
{

    public class Tienda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("nombre")]
        public string nombre { get; set; }

        [BsonElement("ubicacion")]
        public string ubicacion { get; set; }

        [BsonElement("stock")]
        public List<StockProducto> stock { get; set; } = new List<StockProducto>();

        [BsonElement("horarioApertura")]
        public string horarioApertura { get; set; }

        [BsonElement("horarioCierre")]
        public string horarioCierre { get; set; }

        public List<string> trabajadores { get; set; } = new List<string>();
    }

    public class StockProducto
    {
        public string productoID { get; set; }
        public string cantidad { get; set; }
    }

}

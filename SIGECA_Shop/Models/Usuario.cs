﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGECA_Shop.Models
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(
           typeof(Cliente),
           typeof(Trabajador))]
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("tipoUsuario")]
        public string tipoUsuario { get; set; }

        [BsonElement("contraseña")]
        public string contraseña { get; set; }

        [BsonElement("estado")]
        public string estado { get; set; }

        [BsonElement("nombreUsuario")]
        public string nombreUsuario { get; set; }

        [BsonElement("datos")]
        public DatosUsuario datos { get; set; }
        [BsonElement("rol")]
        public string rol { get; set; }
    }

    public class Cliente : Usuario
    {

    }

    public class Trabajador : Usuario
    {
        public DatosLaborales laboral { get; set; }
    }

    #region ClasesInternas
    public class DatosUsuario
    {
        public string email { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
    }

    public class DatosLaborales
    {
        public string tipoContrato { get; set; }
        public string sueldoID { get; set; }
    }

    public class Remuneracion
    {
        public string sueldoID { get; set; }
        public DateTime? fechaPago { get; set; }
        public int horasTrabajadas { get; set; }
        public int descuento { get; set; }
        public int montoSueldo { get; set; }
        public int totalSueldo { get; set; }
    }

    #endregion
}

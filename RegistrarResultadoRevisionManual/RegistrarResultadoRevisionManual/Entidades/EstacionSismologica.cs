using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class EstacionSismologica
    {
        public string CodigoEstacion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Nombre { get; set; }

        public EstacionSismologica(string codigoEstacion, double latitud, double longitud, string nombre)
        {
            CodigoEstacion = codigoEstacion;
            Latitud = latitud;
            Longitud = longitud;
            Nombre = nombre;
        }

        // Constructor vacío para serialización o uso en frameworks que lo requieran
        public EstacionSismologica() { }

        public string GetCodigo() => CodigoEstacion;
    }
}

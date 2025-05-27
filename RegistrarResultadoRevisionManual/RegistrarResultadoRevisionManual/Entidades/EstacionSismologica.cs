using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class EstacionSismologica
    {

        //
        // ATRIBUTOS
        //
        private string CodigoEstacion { get; set; }
        private double Latitud { get; set; }
        private double Longitud { get; set; }
        private string Nombre { get; set; }


        //
        // CONSTRUCTOR
        //
        public EstacionSismologica(string codigoEstacion, double latitud, double longitud, string nombre)
        {
            CodigoEstacion = codigoEstacion;
            Latitud = latitud;
            Longitud = longitud;
            Nombre = nombre;
        }


        //
        // METODOS
        //
        public string GetCodigo() => CodigoEstacion;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class ClasificacionSismo
    {
        private double kmProfundidadDesde;
        private double kmProfundidadHasta;
        private string nombre;

        public ClasificacionSismo(double kmProfundidadDesde, double kmProfundidadHasta, string nombre)
        {
            this.kmProfundidadDesde = kmProfundidadDesde;
            this.kmProfundidadHasta = kmProfundidadHasta;
            this.nombre = nombre;
        }

        public string ObtenerDatosClasificacion()
        {
            return $"{this.nombre}\n Desde: {this.kmProfundidadDesde} km\n Hasta: {this.kmProfundidadHasta} km";
        }

    }

}

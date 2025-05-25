using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class AlcanceSismo
    {
        private string nombre;
        private string descripcion;

        public AlcanceSismo(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string ObtenerDatosAlcance()
        {
            return $"{this.nombre}";
        }

    }

}

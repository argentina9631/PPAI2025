using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class OrigenDeGeneracion
    {
        private string nombre;
        private string descripcion;

        public OrigenDeGeneracion(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class OrigenDeGeneracion
    {
        //
        // ATRIBUTOS
        //
        private string nombre;
        private string descripcion;


        //
        // CONSTRUCTOR
        //
        public OrigenDeGeneracion(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


        //
        // METODOS
        //
        public string getNombre()
        {
            return this.nombre;
        }

    }

}

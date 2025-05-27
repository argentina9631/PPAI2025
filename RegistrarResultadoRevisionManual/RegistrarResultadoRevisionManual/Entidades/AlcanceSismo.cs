using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class AlcanceSismo
    {
        //
        // ATRIBUTOS
        //
        private string nombre;
        private string descripcion;

        //
        // CONSTRUCTOR
        //
        public AlcanceSismo(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        //
        // METODOS
        //
        public string getNombre()
        {
            return $"{this.nombre}";
        }

    }

}

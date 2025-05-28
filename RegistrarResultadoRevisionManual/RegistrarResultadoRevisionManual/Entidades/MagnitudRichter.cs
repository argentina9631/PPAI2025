using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class MagnitudRichter
    {
        //
        // ATRIBUTOS
        //
        private string descripcionMagnitud;
        private double numero;


        //
        // CONSTRUCTOR
        //
        public MagnitudRichter(string descripcionMagnitud, double numero)
        {
            this.descripcionMagnitud = descripcionMagnitud;
            this.numero = numero;
        }


        //
        // METODOS
        //
        public double ObtenerValorMagnitud()
        {
            return this.numero;
        }
    }
}

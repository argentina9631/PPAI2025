using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class MagnitudRichter
    {
        private string descripcionMagnitud;
        private double numero;

        public MagnitudRichter(string descripcionMagnitud, double numero)
        {
            this.descripcionMagnitud = descripcionMagnitud;
            this.numero = numero;
        }
        public string GetDescripcionMagnitud() => descripcionMagnitud;
        public double GetNumero() => numero;
        public double ObtenerValorMagnitud()
        {
            return this.numero;
        }
    }
}

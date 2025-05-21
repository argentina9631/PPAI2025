using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleMuestraSismica
    {
        public TipoDeDato TipoDato { get; set; }
        public double Valor { get; set; }

        public double GetVelocidadOnda()
        {
            return TipoDato?.Nombre == "Velocidad" ? Valor : 0;
        }

        public double GetFrecuenciaOnda()
        {
            return TipoDato?.Nombre == "Frecuencia" ? Valor : 0;
        }

        public double GetLongitudOnda()
        {
            return TipoDato?.Nombre == "Longitud" ? Valor : 0;
        }

        public TipoDeDato ObtenerTipoDeDato()
        {
            return TipoDato;
        }
    }
}


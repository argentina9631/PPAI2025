using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class TipoDeDato
    {
        private string denominacion;
        private string nombreUnidadMedida;
        private double valorUmbral;

        public TipoDeDato(string denominacion, string unidadMedida, double valorUmbral)
        {
            this.denominacion = denominacion;
            this.nombreUnidadMedida = unidadMedida;
            this.valorUmbral = valorUmbral;
        }

        public string GetDenominacion() => denominacion;
        public string GetNombreUnidadMedida() => nombreUnidadMedida;
        public double GetValorUmbral() => valorUmbral;
    }
}

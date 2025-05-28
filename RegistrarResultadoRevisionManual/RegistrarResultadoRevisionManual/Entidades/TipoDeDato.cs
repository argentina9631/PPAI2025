using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class TipoDeDato
    {
        //
        // ATRIBUTOS
        //
        private string denominacion;
        private string nombreUnidadMedida;
        private double valorUmbral;


        //
        // CONSTRUCTOR
        //
        public TipoDeDato(string denominacion, string unidadMedida, double valorUmbral)
        {
            this.denominacion = denominacion;
            this.nombreUnidadMedida = unidadMedida;
            this.valorUmbral = valorUmbral;
        }


        //
        // METODOS
        //
        public string GetDenominacion() => denominacion;
    }
}

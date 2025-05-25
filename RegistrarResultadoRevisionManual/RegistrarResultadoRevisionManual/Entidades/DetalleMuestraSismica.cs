using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class DetalleMuestraSismica
    {
        private TipoDeDato tipoDato;
        private double valor;

        public DetalleMuestraSismica(TipoDeDato tipoDato, double valor)
        {
            this.tipoDato = tipoDato;
            this.valor = valor;
        }

        public TipoDeDato GetTipoDato() => tipoDato;
        public double GetValor() => valor;
    }

}

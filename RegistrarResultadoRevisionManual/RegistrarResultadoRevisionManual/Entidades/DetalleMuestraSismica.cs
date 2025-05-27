using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class DetalleMuestraSismica
    {
        //
        // ATRIBUTOS
        //
        private TipoDeDato tipoDato;
        private double valor;


        //
        // CONSTRUCTOR
        //
        public DetalleMuestraSismica(TipoDeDato tipoDato, double valor)
        {
            this.tipoDato = tipoDato;
            this.valor = valor;
        }


        //
        // METODOS
        //
        public TipoDeDato GetTipoDato() => tipoDato;
        public double GetValor() => valor;
       
    }

}

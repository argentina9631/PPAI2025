using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class MuestraSismica
    {
        //
        // ATRIBUTOS
        //
        private DateTime fechaHora;
        private List<DetalleMuestraSismica> detalles;


        //
        // CONSTRUCTOR
        //
        public MuestraSismica(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
            detalles = new List<DetalleMuestraSismica>();
        }


        //
        // METODOS
        //
        public DateTime GetFechaHora() => fechaHora;
        public List<DetalleMuestraSismica> GetDetalles() => detalles;

        public void AgregarDetalle(DetalleMuestraSismica detalle)
        {
            detalles.Add(detalle);
        }
    }
}

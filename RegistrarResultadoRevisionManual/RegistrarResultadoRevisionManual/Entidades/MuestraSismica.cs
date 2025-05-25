using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class MuestraSismica
    {
        private DateTime fechaHora;
        private List<DetalleMuestraSismica> detalles;

        public MuestraSismica(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
            detalles = new List<DetalleMuestraSismica>();
        }

        public DateTime GetFechaHora() => fechaHora;
        public List<DetalleMuestraSismica> GetDetalles() => detalles;

        public void AgregarDetalle(DetalleMuestraSismica detalle)
        {
            detalles.Add(detalle);
        }
    }
}

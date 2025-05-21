using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CambioEstado
    {
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public Estado Estado { get; set; }

        public void SetFechaHoraFin(DateTime fecha)
        {
            FechaHoraFin = fecha;
        }

        public bool EsEstadoActual()
        {
            return FechaHoraFin == null;
        }

        public bool EsBloqueado()
        {
            return Estado?.Nombre == "Bloqueado";
        }

        public bool EsPendienteRevision()
        {
            return Estado?.Nombre == "Pendiente de Revisión";
        }

        public bool EsRechazado()
        {
            return Estado?.Nombre == "Rechazado";
        }
    }
}


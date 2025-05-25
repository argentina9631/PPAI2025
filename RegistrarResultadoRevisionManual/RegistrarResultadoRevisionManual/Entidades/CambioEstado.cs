using System;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class CambioEstado
    {
        public Estado Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }  // Nullable para poder marcar cuando termina el estado

        public CambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            Estado = estado;
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = null;
        }

        public void registrarFechaHoraFin(DateTime fechaHoraFin)
        {
            setFechaHoraFin(fechaHoraFin);
        }
        private void setFechaHoraFin(DateTime fechaHoraFin)
        {
            FechaHoraFin = fechaHoraFin;
        }


        public bool estasAutoDetectado()
        {
            return Estado != null && Estado.esAutoDetectado();
        }
    }
}

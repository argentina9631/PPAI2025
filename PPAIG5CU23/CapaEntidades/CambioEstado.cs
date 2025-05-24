using System;

namespace CapaEntidades
{
    public class CambioEstado
    {
        public Estado Estado { get; set; }                // Estado asignado (por ejemplo: "Bloqueado", "Rechazado")
        public DateTime FechaHoraInicio { get; set; }     // Cuándo empezó este estado
        public DateTime? FechaHoraFin { get; set; }       // Cuándo terminó (null si está activo)
        public Usuario Responsable { get; set; }          // Quién hizo el cambio de estado

        public CambioEstado(Estado estado, DateTime fechaHoraInicio, Usuario responsable)
        {
            Estado = estado;
            FechaHoraInicio = fechaHoraInicio;
            Responsable = responsable;
            FechaHoraFin = null; // Inicialmente activo
        }

        // 24 : setFechaHoraFin
        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            // Asigna la fecha de finalización del estado
            this.FechaHoraFin = fechaHoraFin;
        }

        // 67 : setResponsableCambio
        public void setResponsableCambio(Usuario responsable)
        {
            // Asigna el usuario responsable del cambio
            this.Responsable = responsable;
        }
    }
}

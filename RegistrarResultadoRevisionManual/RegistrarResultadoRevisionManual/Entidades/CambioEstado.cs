using System;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class CambioEstado
    {
        //
        // ATRIBUTOS
        //
        private Estado Estado { get; set; }
        private DateTime FechaHoraInicio { get; set; }
        private DateTime? FechaHoraFin { get; set; }  // Nullable para poder marcar cuando termina el estado
        private Usuario UsuarioResponsable { get; set; }



        //
        // CONSTRUCTOR
        //
        public CambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            Estado = estado;
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraFin = null;
        }



        //
        // METODOS
        //
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

        public void RegistrarUsuarioResponsable(Usuario usuarioResponsable)
        {
            if (usuarioResponsable == null)
            {
                throw new ArgumentNullException(nameof(usuarioResponsable), "El usuario responsable no puede ser nulo.");
            }
            UsuarioResponsable = usuarioResponsable;
        }
    }
}

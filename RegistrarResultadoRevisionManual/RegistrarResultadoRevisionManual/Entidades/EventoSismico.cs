using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class EventoSismico
    {
        //
        // ATRIBUTOS
        //
        private int id;
        private string ubicacion;
        private MagnitudRichter magnitud;
        private List<CambioEstado> cambiosEstado;
        private DateTime fechaHoraOcurrencia;
        private double latitudEpicentro;
        private double longitudEpicentro;
        private double latitudHipocentro;
        private double longitudHipocentro;
        private ClasificacionSismo clasificacion;
        private OrigenDeGeneracion origen;
        private AlcanceSismo alcance;
        private List<SerieTemporal> seriesTemporales;


        //
        // CONSTRUCTOR
        //
        public EventoSismico(int id, string ubicacion, MagnitudRichter magnitud, DateTime fechaHoraOcurrencia,
        double latEpicentro, double longEpicentro, double latHipocentro, double longHipocentro,
        ClasificacionSismo clasificacion, OrigenDeGeneracion origen, AlcanceSismo alcance,
        List<CambioEstado> cambiosEstado = null,
        List<SerieTemporal> seriesTemporales = null)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.magnitud = magnitud;
            this.fechaHoraOcurrencia = fechaHoraOcurrencia;
            this.latitudEpicentro = latEpicentro;
            this.longitudEpicentro = longEpicentro;
            this.latitudHipocentro = latHipocentro;
            this.longitudHipocentro = longHipocentro;
            this.clasificacion = clasificacion;
            this.origen = origen;
            this.alcance = alcance;
            this.cambiosEstado = cambiosEstado ?? new List<CambioEstado>();
            this.seriesTemporales = seriesTemporales ?? new List<SerieTemporal>();  // asignar la lista
        }


        //
        // METODOS
        //
        public string ObtenerAlcanceSismo()
        {
            if (alcance == null) return "Alcance no definido";
            return alcance.getNombre();
        }

        public string ObtenerClasificacionSismo()
        {
            if (clasificacion == null) return "Clasificación no definida";
            return clasificacion.ObtenerDatosClasificacion();
        }

        public string ObtenerOrigenSismo()
        {
            if (origen == null) return "Origen no definido";
            return origen.getNombre();
        }

        public double ObtenerMagnitudSismo()
        {
            if (magnitud == null) return 0;
            return magnitud.ObtenerValorMagnitud();
        }
        public List<SerieTemporal> GetSeriesTemporales() => seriesTemporales;

        public DateTime GetFechaHoraOcurrencia()
        {
            return fechaHoraOcurrencia;
        }

        public string GetUbicacionEventoSismico()
        {
            // Retorna latitud y longitud del epicentro
            return $"Latitud: {latitudEpicentro}, Longitud: {longitudEpicentro}";
        }



        //
        // MÉTODOS DE ESTADO
        //
        public void bloquear(Estado estadoBloqueado, DateTime fechaHoraActual)
        {
            if (cambiosEstado == null)
            {
                cambiosEstado = new List<CambioEstado>();
            }

            var ultimoCambio = obtenerEstadoActual();
            if (ultimoCambio != null)
            {
                ultimoCambio.registrarFechaHoraFin(fechaHoraActual);
            }

            crearCambioDeEstadoNuevo(estadoBloqueado);
        }

        public void rechazar(Estado estadoRechazado, DateTime fechaHoraActual, Usuario usuarioResponsable)
        {
            if (cambiosEstado == null)
            {
                cambiosEstado = new List<CambioEstado>();
            }

            var ultimoCambio = obtenerEstadoActual();
            if (ultimoCambio != null)
            {
                ultimoCambio.registrarFechaHoraFin(fechaHoraActual);
                ultimoCambio.RegistrarUsuarioResponsable(usuarioResponsable);
            }
            crearCambioDeEstadoNuevo(estadoRechazado);

            MessageBox.Show($"El evento sismico con ID {id} ha sido rechazado por {usuarioResponsable.GetNombreUsuario()}.", "Evento Rechazado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ES EL ULTIMO DATO DEL ARREGLO CAMBIO ESTADO
        //
        // NO SE USA EL esEstadoActual del DIAGRAMA DE SECUENCIAS
        public CambioEstado obtenerEstadoActual()
        {
            if (cambiosEstado != null && cambiosEstado.Count > 0)
                return cambiosEstado[cambiosEstado.Count - 1];
            return null;
        }

        public string getDatos()
        {
            return $"Fecha y hora: {fechaHoraOcurrencia}, " +
                   $"Epicentro: ({latitudEpicentro}, {longitudEpicentro}), " +
                   $"Hipocentro: ({latitudHipocentro}, {longitudHipocentro}), " +
                   $"Magnitud: {magnitud.ObtenerValorMagnitud()}";
        }

        public void crearCambioDeEstadoNuevo(Estado estadoACambiar)
        {
            var nuevoEstado = new CambioEstado(estadoACambiar, DateTime.Now);
            cambiosEstado.Add(nuevoEstado);
        }
    }

}

using System;
using System.Collections.Generic;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class EventoSismico
    {
        // ATRIBUTOS PRIVADOS
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

        // CONSTRUCTOR
        public EventoSismico(int id, string ubicacion, MagnitudRichter magnitud, DateTime fechaHoraOcurrencia,
    double latEpicentro, double longEpicentro, double latHipocentro, double longHipocentro,
    ClasificacionSismo clasificacion, OrigenDeGeneracion origen, AlcanceSismo alcance,
    List<CambioEstado> cambiosEstado = null,
    List<SerieTemporal> seriesTemporales = null)  // <---- agregar aquí
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


        // GETTERS
        public int GetId() => id;
        public string GetUbicacion() => ubicacion;
        public List<CambioEstado> GetCambiosEstado() => cambiosEstado;
        public DateTime GetFechaHoraOcurrencia() => fechaHoraOcurrencia;
        public double GetLatitudEpicentro() => latitudEpicentro;
        public double GetLongitudEpicentro() => longitudEpicentro;
        public double GetLatitudHipocentro() => latitudHipocentro;
        public double GetLongitudHipocentro() => longitudHipocentro;

        public string GetAlcance()
        {
            if (alcance == null) return "Alcance no definido";
            return alcance.ObtenerDatosAlcance();
        }

        public string GetClasificacion()
        {
            if (clasificacion == null) return "Clasificación no definida";
            return clasificacion.ObtenerDatosClasificacion();
        }

        public string GetOrigen()
        {
            if (origen == null) return "Origen no definido";
            return origen.ObtenerDatosOrigen();
        }

        public double GetMagnitud()
        {
            if (magnitud == null) return 0;
            return magnitud.ObtenerValorMagnitud();
        }

        public List<SerieTemporal> GetSeriesTemporales() => seriesTemporales;

        
        
        
        // MÉTODOS EXISTENTES
        public void bloquear(Estado estadoBloqueado, DateTime fechaHoraActual)
        {
            if (cambiosEstado == null)
            {
                cambiosEstado = new List<CambioEstado>();
            }

            var ultimoCambio = obtenerEstadoActual();
            if (ultimoCambio != null)
            {
                ultimoCambio.setFechaHoraFin(fechaHoraActual);
            }

            var nuevoCambio = new CambioEstado(estadoBloqueado, fechaHoraActual);
            cambiosEstado.Add(nuevoCambio);
        }

        public CambioEstado obtenerEstadoActual()
        {
            if (cambiosEstado != null && cambiosEstado.Count > 0)
                return cambiosEstado[cambiosEstado.Count - 1];
            return null;
        }

        public bool estasAutoDetectado()
        {
            var actual = obtenerEstadoActual();
            return actual != null && actual.estasAutoDetectado();
        }

        public string getDatos()
        {
            return $"Fecha y hora: {fechaHoraOcurrencia}, " +
                   $"Epicentro: ({latitudEpicentro}, {longitudEpicentro}), " +
                   $"Hipocentro: ({latitudHipocentro}, {longitudHipocentro}), " +
                   $"Magnitud: {magnitud.ObtenerValorMagnitud()}";
        }
    }
}

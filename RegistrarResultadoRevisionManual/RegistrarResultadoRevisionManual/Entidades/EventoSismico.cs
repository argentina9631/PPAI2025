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

        public Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>> ObtenerSeriesTemporales()
        {
            var datosPorEstacion = new Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>>();

            foreach (var serie in this.GetSeriesTemporales())
            {
                var codigoEstacion = serie.ConocerCodigoEstacionSismologica();

                if (!datosPorEstacion.ContainsKey(codigoEstacion))
                    datosPorEstacion[codigoEstacion] = new Dictionary<DateTime, Dictionary<string, double>>();

                foreach (var muestra in serie.GetMuestras())
                {
                    var instante = muestra.GetFechaHora();

                    if (!datosPorEstacion[codigoEstacion].ContainsKey(instante))
                        datosPorEstacion[codigoEstacion][instante] = new Dictionary<string, double>();

                    foreach (var detalle in muestra.GetDetalles())
                    {
                        var tipoDato = detalle.GetTipoDato();
                        var denominacion = detalle.GetDenominacionDato().ToLower();
                        var valor = detalle.GetValor();

                        if (denominacion.Contains("velocidad"))
                            datosPorEstacion[codigoEstacion][instante]["Velocidad de onda"] = valor;
                        else if (denominacion.Contains("frecuencia"))
                            datosPorEstacion[codigoEstacion][instante]["Frecuencia de onda"] = valor;
                        else if (denominacion.Contains("longitud"))
                            datosPorEstacion[codigoEstacion][instante]["Longitud de onda"] = valor;
                    }
                }
            }

            return datosPorEstacion;
        }


        public DateTime GetFechaHoraOcurrencia()
        {
            return fechaHoraOcurrencia;
        }

        public string GetUbicacionEventoSismico()
        {
            // Retorna latitud y longitud del epicentro
            return $"Latitud: {latitudEpicentro}, Longitud: {longitudEpicentro}";
        }

        private List<SerieTemporal> GetSeriesTemporales()
        {
            return seriesTemporales;
        }


        //
        // MÉTODOS DE ESTADO
        //
        public void bloquear(Estado estadoBloqueado, DateTime fechaHoraActual)
        {
            var ultimoCambio = obtenerEstadoActual();
            ultimoCambio.registrarFechaHoraFin(fechaHoraActual);

            crearCambioDeEstadoNuevo(estadoBloqueado);
        }

        public void rechazar(Estado estadoRechazado, DateTime fechaHoraActual, Usuario usuarioResponsable)
        {

            var ultimoCambio = obtenerEstadoActual();
            if (ultimoCambio != null)
            {
                ultimoCambio.registrarFechaHoraFin(fechaHoraActual);
                ultimoCambio.RegistrarUsuarioResponsable(usuarioResponsable);
            }
            crearCambioDeEstadoNuevo(estadoRechazado);

            MessageBox.Show($"El evento sismico ha sido rechazado por {usuarioResponsable.GetNombreUsuario()}.", "Evento Rechazado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private CambioEstado obtenerEstadoActual()
        {
            if (cambiosEstado != null && cambiosEstado.Count > 0)
                return cambiosEstado[cambiosEstado.Count - 1];
            return null;
        }

        public bool EsAutoDetectado()
        {
            var estadoActual = this.obtenerEstadoActual();
            return estadoActual != null && estadoActual.estasAutoDetectado();
        }

        private void crearCambioDeEstadoNuevo(Estado estadoACambiar)
        {
            var nuevoEstado = new CambioEstado(estadoACambiar, DateTime.Now);
            cambiosEstado.Add(nuevoEstado);
        }
    }

}

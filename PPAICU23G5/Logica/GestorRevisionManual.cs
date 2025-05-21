//using System.Text;
//using System.Threading.Tasks;
using Datos;
using Entidades;
//using PPAICU23G5.Logica;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class GestorRevisionManual
    {
        private EventoSismico eventoSeleccionado;
        private List<EventoSismico> eventosPendientes;

        public List<EventoSismico> BuscarEventoPendienteRevision()
        {
            // Simula acceso a datos. Acá deberías consultar desde DAO
            eventosPendientes = EventoSismicoDAO.BuscarEventosPendientes();
            eventosPendientes = eventosPendientes.OrderBy(e => e.FechaHoraOcurrencia).ToList();
            return eventosPendientes;
        }

        public void TomarSeleccionEvento(EventoSismico evento)
        {
            eventoSeleccionado = evento;
        }

        public bool ValidarEstadoPendiente()
        {
            return eventoSeleccionado.ObtenerEstadoActual().EsPendienteRevision();
        }

        public bool ValidarEstadoBloqueado()
        {
            return eventoSeleccionado.ObtenerEstadoActual().EsBloqueado();
        }

        public void BloquearEvento()
        {
            DateTime ahora = DateTime.Now;

            // Finaliza el estado actual
            var estadoActual = eventoSeleccionado.ObtenerEstadoActual();
            estadoActual.SetFechaHoraFin(ahora);

            // Crea nuevo estado "Bloqueado"
            var nuevoCambioEstado = new CambioEstado
            {
                FechaHoraInicio = ahora,
                Estado = EstadoDAO.BuscarEstadoBloqueado()
            };

            eventoSeleccionado.RegistrarBloqueo(nuevoCambioEstado);
            EventoSismicoDAO.ActualizarEstado(eventoSeleccionado);
        }

        public string ObtenerAlcance()
        {
            return eventoSeleccionado.Alcance?.GetNombre();
        }

        public string ObtenerClasificacion()
        {
            return eventoSeleccionado.Clasificacion?.GetNombre();
        }

        public string ObtenerOrigen()
        {
            return eventoSeleccionado.Origen?.GetNombre();
        }

        public List<SerieTemporal> ObtenerSeriesTemporales()
        {
            return eventoSeleccionado.SeriesTemporales;
        }

        public List<MuestraSismica> ObtenerMuestras(SerieTemporal serie)
        {
            return serie.ObtenerMuestras();
        }

        public List<DetalleMuestraSismica> ObtenerDetalles(MuestraSismica muestra)
        {
            return muestra.ObtenerDatos();
        }

        public EstacionSismologica ObtenerEstacion(SerieTemporal serie)
        {
            return serie.Sismografo.ObtenerEstacionSismologica();
        }

        public void GenerarSismograma(SerieTemporal serie)
        {
            // Acá se llamaría a otro CU incluido
            GeneradorSismograma.Generar(serie);
        }

        public bool ValidarRechazo()
        {
            return eventoSeleccionado.ObtenerEstadoActual().EsRechazado();
        }
    }
}


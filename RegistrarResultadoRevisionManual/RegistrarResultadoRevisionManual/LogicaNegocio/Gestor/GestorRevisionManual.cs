using RegistrarResultadoRevisionManual.DatosMock;
using RegistrarResultadoRevisionManual.Entidades;
using RegistrarResultadoRevisionManual.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.LogicaNegocio
{
    public class GestorRevisionManual
    {
        //
        // ATRIBUTOS
        //
        private EventoSismico eventoSeleccionado;
        private Estado estadoBloqueado;
        private DateTime fechaHoraActual;
        private Usuario usuarioActual;
        private Estado estadoRechazado;
        private string[] datosGenerales;
        private string datosTemporales;
        private Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>> datosPorEstacion;
        private PantallaRegistrarRevisionManual pantallaRegistrarRevisionManual;


        //
        // CONSTRUCTOR
        //

        public GestorRevisionManual(PantallaRegistrarRevisionManual pantalla)
        {
            this.pantallaRegistrarRevisionManual = pantalla;
        }


        //
        // METODOS
        //
        public void opcRegistrarResultadoRevision()
        {
            var eventosAutoDetectados = buscarEventosAutoDetectados();
            var autoDetectadosOrdenados = ordenarEventosPorFechaHora(eventosAutoDetectados);
            pantallaRegistrarRevisionManual.mostrarDatosOrdenados(autoDetectadosOrdenados.ToList());
        }

        public List<EventoSismico> buscarEventosAutoDetectados()
        {
            return MockEventos.ObtenerTodosLosEventos()
                .Where(evento => evento.EsAutoDetectado())
                .ToList();
        }

        private IOrderedEnumerable<EventoSismico> ordenarEventosPorFechaHora(List<EventoSismico> eventos)
        {
            return eventos.OrderByDescending(e => e.GetFechaHoraOcurrencia());
        }

        private void registrarBloqueo()
        {
            eventoSeleccionado.bloquear(estadoBloqueado, fechaHoraActual);
            MessageBox.Show("Evento bloqueado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void TomarSelecEventoSismico(EventoSismico evento)
        {
            this.eventoSeleccionado = evento;
            fechaHoraActual = ObtenerFechaHoraActual();
            estadoBloqueado = BuscarEstadoBloqueado();

            registrarBloqueo();

            datosGenerales = ObtenerDatosGeneralesDelEvento();
            datosTemporales = ObtenerSeriesTemporalesDelEvento();

            llamarCUGenerarSismograma();

            pantallaRegistrarRevisionManual.MostrarDatosEvento(datosGenerales, datosTemporales);
        }

        public void tomarRechazarEvento()
        {
            if (!validarDatosNecesarios())
                return;

            estadoRechazado = buscarEstadoRechazado();
            usuarioActual = obtenerUsuario();
            fechaHoraActual = ObtenerFechaHoraActual();

            eventoSeleccionado.rechazar(estadoRechazado, fechaHoraActual, usuarioActual);
            finCU();
        }

        private string[] ObtenerDatosGeneralesDelEvento()
        {
            string alcance = eventoSeleccionado.ObtenerAlcanceSismo();
            string magnitud = eventoSeleccionado.ObtenerMagnitudSismo().ToString();
            string clasificacion = eventoSeleccionado.ObtenerClasificacionSismo();
            string origen = eventoSeleccionado.ObtenerOrigenSismo();

            return new string[] { magnitud, alcance, clasificacion, origen };
        }

        private string ObtenerSeriesTemporalesDelEvento()
        {
            var seriesDelEvento = eventoSeleccionado.ObtenerSeriesTemporales();
            var seriesOrdenadas = ordenarSeriesTemporalesPorEstacion(seriesDelEvento);
            return seriesOrdenadas;
        }

        private string ordenarSeriesTemporalesPorEstacion(Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>> seriesDelEvento)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var estacion in seriesDelEvento)
            {
                sb.AppendLine($"Estación: {estacion.Key}");
                foreach (var instante in estacion.Value.OrderBy(i => i.Key))
                {
                    sb.AppendLine($"  Instante: {instante.Key}");
                    foreach (var dato in instante.Value)
                    {
                        sb.AppendLine($"    {dato.Key}: {dato.Value}");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void llamarCUGenerarSismograma()
        {
            MessageBox.Show("Llamando al caso de uso para generar el sismograma.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Estado BuscarEstadoBloqueado()
        {
            return MockEstado.ObtenerTodosLosEstados()
                .FirstOrDefault(e => e.esAmbitoEventoSismico() && e.esBloqueado());
        }

        private DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        private Usuario obtenerUsuario()
        {
            return Sesion.Instancia.ObtenerUsuarioActual();
        }

        private bool validarDatosNecesarios()
        {
            double magnitud = eventoSeleccionado.ObtenerMagnitudSismo();
            if (double.IsNaN(magnitud) || magnitud == 0)
            {
                MessageBox.Show("La magnitud del evento no está especificada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(eventoSeleccionado.ObtenerAlcanceSismo()))
            {
                MessageBox.Show("El alcance del evento no está especificado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(eventoSeleccionado.ObtenerOrigenSismo()))
            {
                MessageBox.Show("El origen del evento no está especificado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private Estado buscarEstadoRechazado()
        {
            return MockEstado.ObtenerTodosLosEstados()
                .FirstOrDefault(e => e.esAmbitoEventoSismico() && e.esRechazado());
        }

        private void finCU()
        {
            MessageBox.Show("Caso de uso finalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}


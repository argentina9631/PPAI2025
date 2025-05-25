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
        private EventoSismico eventoSeleccionado;


        public List<EventoSismico> OpcRegResultadoObservacion()
        {
            var todosEventos = buscarEventos();
            List<EventoSismico> autoDetectados = new List<EventoSismico>();


            foreach (var evento in todosEventos)
            {
                var estadoActual = evento.obtenerEstadoActual();

                if (estadoActual != null && estadoActual.estasAutoDetectado())
                {
                    autoDetectados.Add(evento);
                }
            }
            OrdenarEventosPorFechaHora(autoDetectados);
            return autoDetectados;
        }

        public IOrderedEnumerable<EventoSismico> OrdenarEventosPorFechaHora(List<EventoSismico> eventos)
        {
            return eventos.OrderByDescending(e => e.GetFechaHoraOcurrencia());
        }


        private void registrarBloqueo(EventoSismico eventoSeleccionado, Estado estadoBloqueado, DateTime fechaHoraActual)
        {
            eventoSeleccionado.bloquear(estadoBloqueado, fechaHoraActual);
            System.Windows.Forms.MessageBox.Show("Evento bloqueado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //
        // METODOS INTERACCION CON LA INTERFAZ
        public void TomarSelecEventoSismico(EventoSismico evento)
        {
            this.eventoSeleccionado = evento;
            var fechaHoraActual = ObtenerFechaHoraActual();
            var estadoBloqueado = BuscarEstadoBloqueado();

            registrarBloqueo(eventoSeleccionado, estadoBloqueado, fechaHoraActual);

            var datosGenerales = ObtenerDatosGeneralesDelEvento();
            string datosTemporales = ObtenerSeriesTemporalesDelEvento();

            llamarCUGenerarSismograma();

            MostrarDatosEvento(datosGenerales, datosTemporales);
        }

        public void tomarRechazarEvento()
        {
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("No hay un evento cargado para rechazar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validaciones de campos requeridos
            bool datosValidos = validarDatosNecesarios();
            if (!datosValidos)
            {
                // Si no son válidos, salir sin continuar
                return;
            }

            // Busqueda Estado Rechazado
            var estadoRechazado = buscarEstadoRechazado();

            // Obtener fecha y hora actual
            var fechaHoraActual = ObtenerFechaHoraActual();

            // Registrar el cambio de estado
            eventoSeleccionado.rechazar(estadoRechazado, fechaHoraActual);

            MessageBox.Show("Evento rechazado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            finCU();
        }



        // 
        // METODOS PRINCIPALES
        //

        public string[] ObtenerDatosGeneralesDelEvento()
        {
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("No hay ningún evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var magnitud = eventoSeleccionado.ObtenerMagnitudSismo().ToString();
            var alcance = eventoSeleccionado.ObtenerAlcanceSismo();
            var clasificacion = eventoSeleccionado.ObtenerClasificacionSismo();
            var origen = eventoSeleccionado.ObtenerOrigenSismo();

            return new string[] { magnitud, alcance, clasificacion, origen };
        }


        public string ObtenerSeriesTemporalesDelEvento()
        {
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("No hay ningún evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>> datosPorEstacion =
                new Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>>();

            var series = eventoSeleccionado.GetSeriesTemporales();

            foreach (var serie in series)
            {
                var codigoEstacion = serie.ConocerCodigoEstacionSismologica();
                if (codigoEstacion == null) continue;

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
                        var denominacion = tipoDato.GetDenominacion().ToLower();
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

            StringBuilder sb = new StringBuilder();

            foreach (var estacion in datosPorEstacion)
            {
                sb.AppendLine($"Estación Sismológica: {estacion.Key}");

                var instantes = estacion.Value.OrderBy(pair => pair.Key);

                foreach (var instanteEntry in instantes)
                {
                    var instante = instanteEntry.Key;
                    var datos = instanteEntry.Value;

                    sb.AppendLine($"  Instante: {instante}");
                    if (datos.ContainsKey("Velocidad de onda"))
                        sb.AppendLine($"    Velocidad de onda: {datos["Velocidad de onda"]}");
                    if (datos.ContainsKey("Frecuencia de onda"))
                        sb.AppendLine($"    Frecuencia de onda: {datos["Frecuencia de onda"]}");
                    if (datos.ContainsKey("Longitud de onda"))
                        sb.AppendLine($"    Longitud de onda: {datos["Longitud de onda"]}");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void MostrarDatosEvento(string[] datosGenerales, string datosTemporales)
        {
            DetalleDelEvento ventana = new DetalleDelEvento(datosGenerales, datosTemporales);
            ventana.SetGestor(this); // Pasás el propio gestor que llama
            ventana.Show();

        }




        // 
        // METODOS DE BUSQUEDA Y SELFS DEL GESTOR
        // 
        private void llamarCUGenerarSismograma()
        { 
            MessageBox.Show("Llamando al caso de uso para generar el sismograma.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Estado BuscarEstadoBloqueado()
        {
            return MockEstado.ObtenerTodosLosEstados()
                .FirstOrDefault(e => e.esAmbitoEventoSismico() && e.esBloqueado());
        }

        private List<EventoSismico> buscarEventos()
        {
            return MockEventos.ObtenerTodosLosEventos();
        }

        private DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        private string obtenerUsuario()
        {
            return "UsuarioActual";
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

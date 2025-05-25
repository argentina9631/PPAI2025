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
            var todos = buscarEventos();

            var autoDetectados = todos
                .Where(e => e.estasAutoDetectado())
                .OrderByDescending(e => e.GetFechaHoraOcurrencia())
                .ToList();

            return autoDetectados;
        }

        private void registrarBloqueo(EventoSismico eventoSeleccionado)
        {
            var estadoBloqueado = BuscarEstadoBloqueado();
            var fechaHoraActual = ObtenerFechaHoraActual();
            eventoSeleccionado.bloquear(estadoBloqueado, fechaHoraActual);
            System.Windows.Forms.MessageBox.Show("Evento bloqueado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.MessageBox.Show($"Evento bloqueado: {eventoSeleccionado.getDatos()} por el usuario {obtenerUsuario()} en {fechaHoraActual}");
        }

        public void TomarSelecEventoSismico(EventoSismico evento)
        {
            this.eventoSeleccionado = evento;
            registrarBloqueo(eventoSeleccionado);

            string datos = buscarDatosSismicosDelEvento();

            var ventanaDetalle = new RegistrarResultadoRevisionManual.Presentacion.DetalleDelEvento(datos, evento);
            ventanaDetalle.Show();
        }




        // METODOS DE BUSQUEDA Y SELFS DEL GESTOR
        //
        // 
        private Estado BuscarEstadoBloqueado()
        {
            return MockEstado.ObtenerTodosLosEstados()
                .FirstOrDefault(e => e.esAmbito("EventoSismico") && e.esNombre("Bloqueado"));
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
            return "UsuarioActual"; // Aquí deberías implementar la lógica para obtener el usuario actual
        }

        public string buscarDatosSismicosDelEvento()
        {
            if (eventoSeleccionado == null)
            {
                MessageBox.Show("No hay ningún evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var alcance = eventoSeleccionado.GetAlcance();
            var clasificacion = eventoSeleccionado.GetClasificacion();
            var origen = eventoSeleccionado.GetOrigen();

            Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>> datosPorEstacion =
                new Dictionary<string, Dictionary<DateTime, Dictionary<string, double>>>();

            var series = eventoSeleccionado.GetSeriesTemporales();

            foreach (var serie in series)
            {
                var estacion = serie.GetEstacionSismologica();
                if (estacion == null) continue;

                string codigoEstacion = estacion.GetCodigo();

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
            sb.AppendLine($"Alcance: {alcance}");
            sb.AppendLine($"Clasificación: {clasificacion}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine();

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

    }
}

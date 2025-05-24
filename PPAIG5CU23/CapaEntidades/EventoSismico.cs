using System;
using System.Collections.Generic;

namespace CapaEntidades
{
    public class EventoSismico
    {
        // Atributos principales del evento
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Ubicacion { get; set; }
        public double Magnitud { get; set; }

        // Lista de cambios de estado del evento
        private List<CambioEstado> historialEstados;

        public EventoSismico()
        {
            historialEstados = new List<CambioEstado>();
        }

        // 6 : obtenerEstadoActual
        public Estado obtenerEstadoActual()
        {
            // Devuelve el último estado registrado (el actual)
            if (historialEstados.Count == 0)
                return null;

            // Ordenamos por fecha de inicio descendente y tomamos el más reciente
            historialEstados.Sort((c1, c2) => c2.FechaHoraInicio.CompareTo(c1.FechaHoraInicio));
            return historialEstados[0].Estado;
        }

        // 7 : esEstadoActual
        public bool esEstadoActual(Estado estado)
        {
            // Compara si el estado pasado por parámetro es el mismo que el estado actual
            Estado actual = obtenerEstadoActual();
            return actual != null && actual.Nombre == estado.Nombre;
        }

        // 9 : esAutoDetectado
        public bool esAutoDetectado()
        {
            // Verifica si el estado actual es "AutoDetectado"
            Estado actual = obtenerEstadoActual();
            return actual != null && actual.Nombre == "AutoDetectado";
        }

        // 24 : setFechaHoraFin (en CambioEstado)
        public void cerrarEstadoActual(DateTime fechaFin)
        {
            // Cierra el estado actual, asignándole la fecha y hora de fin
            if (historialEstados.Count > 0)
                historialEstados[0].FechaHoraFin = fechaFin;
        }

        // 25 : crearCambioEstadoEvento
        public void agregarCambioEstado(CambioEstado nuevoCambio)
        {
            // Agrega un nuevo cambio de estado al historial
            historialEstados.Add(nuevoCambio);
        }

        // 65 : getEstadoActual (acceso directo usado en el paso 65)
        public CambioEstado getCambioEstadoActual()
        {
            // Devuelve el cambio de estado más reciente
            if (historialEstados.Count == 0)
                return null;

            historialEstados.Sort((c1, c2) => c2.FechaHoraInicio.CompareTo(c1.FechaHoraInicio));
            return historialEstados[0];
        }

        //para GeneradorSismograma de capa Logica
        public List<SerieTemporal> SeriesTemporales { get; set; } = new List<SerieTemporal>();

    }
}

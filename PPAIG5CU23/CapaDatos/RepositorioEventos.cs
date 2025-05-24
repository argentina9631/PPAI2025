using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidades;

namespace CapaDatos
{
    public class RepositorioEventos
    {
        // Simulamos una base de datos con una lista en memoria
        private List<EventoSismico> eventos;

        public RepositorioEventos()
        {
            eventos = new List<EventoSismico>();

            // Cargar datos de ejemplo
            cargarEventosPrueba();
        }

        // 4 : buscarEventoAutoDetectado
        public List<EventoSismico> obtenerEventosAutoDetectados()
        {
            // Devuelve todos los eventos cuyo estado actual es "AutoDetectado"
            return eventos.Where(e => e.esAutoDetectado()).ToList();
        }

        // 27 : buscarDatosSismiciosDeEvento
        public EventoSismico obtenerEventoPorId(int id)
        {
            // Busca el evento con el ID proporcionado
            return eventos.FirstOrDefault(e => e.Id == id);
        }

        private void cargarEventosPrueba()
        {
            // Crea estados
            Estado autoDetectado = new Estado("AutoDetectado");
            Estado bloqueado = new Estado("Bloqueado");

            // Crea usuario ficticio
            Usuario usuario = new Usuario(1, "Analista Sismos");

            // Crea evento 1
            EventoSismico evento1 = new EventoSismico
            {
                Id = 101,
                FechaHora = DateTime.Now.AddHours(-5),
                Ubicacion = "Zona Norte",
                Magnitud = 4.5
            };
            evento1.agregarCambioEstado(new CambioEstado(autoDetectado, DateTime.Now.AddHours(-5), usuario));

            // Crea evento 2
            EventoSismico evento2 = new EventoSismico
            {
                Id = 102,
                FechaHora = DateTime.Now.AddHours(-3),
                Ubicacion = "Zona Sur",
                Magnitud = 5.1
            };
            evento2.agregarCambioEstado(new CambioEstado(bloqueado, DateTime.Now.AddHours(-3), usuario));

            eventos.Add(evento1);
            eventos.Add(evento2);
        }
    }
}

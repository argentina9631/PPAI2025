using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaDatos;

namespace CapaLogica
{
    public class GestorRevisionManual
    {
        private Usuario usuarioLogueado;
        private EventoSismico eventoSeleccionado;
        private RepositorioEventos repositorioEventos;
        private RepositorioUsuarios repositorioUsuarios;

        public GestorRevisionManual()
        {
            // Inicializa los repositorios (capa de datos)
            repositorioEventos = new RepositorioEventos();
            repositorioUsuarios = new RepositorioUsuarios();
        }

        // 1 : opcRegResultadoObservacion
        public void opcRegResultadoObservacion()
        {
            // Paso 1: El usuario solicita registrar un resultado de observación.
            habilitarPantalla();

            // Paso 4: Busca eventos sísmicos auto detectados.
            List<EventoSismico> eventos = buscarEventoAutoDetectado();

            // Paso 11: Ordena los eventos por fecha y hora.
            eventos.Sort((e1, e2) => e1.FechaHora.CompareTo(e2.FechaHora));

            // Paso 12: Muestra los datos en la pantalla (simulado).
            // Aquí llamaríamos a la pantalla para mostrar los datos.
        }

        // 2 : habilitarPantalla
        private void habilitarPantalla()
        {
            // Se encarga de habilitar la pantalla (invocaría a PantallaRevisionManual.habilitarPantalla)
            // Este método se ejecuta desde la lógica para pedir a la presentación que se active.
        }

        // 4 : buscarEventoAutoDetectado
        private List<EventoSismico> buscarEventoAutoDetectado()
        {
            // Recupera eventos desde la base de datos marcados como autodetectados.
            return repositorioEventos.obtenerEventosAutoDetectados();
        }

        // 5 : conocerEstadoActual
        private Estado conocerEstadoActual(EventoSismico evento)
        {
            // Devuelve el estado actual del evento.
            return evento.obtenerEstadoActual();
        }

        // 6 : obtenerEstadoActual
        // se asume en la entidad EventoSismico (lo veremos más adelante)

        // 7 : *esEstadoActual
        // se usa para validar si un estado es el último (lo veremos en la entidad)

        // 8 : estasAutoDetectado
        private bool estasAutoDetectado(EventoSismico evento)
        {
            // Verifica si el estado del evento es "AutoDetectado"
            return evento.esAutoDetectado();
        }

        // 15 : obtenerFechaHoraActual
        private DateTime obtenerFechaHoraActual()
        {
            // Obtiene la fecha y hora actual del sistema
            return DateTime.Now;
        }

        // 19 : conocerUsuarioLogeado
        private Usuario conocerUsuarioLogeado()
        {
            // Devuelve el usuario que está usando el sistema actualmente
            return usuarioLogueado;
        }

        // 27 : buscarDatosSismiciosDeEvento
        private EventoSismico buscarDatosSismiciosDeEvento(int idEvento)
        {
            // Busca el evento sismico con datos completos
            return repositorioEventos.obtenerEventoPorId(idEvento);
        }

        // Otros métodos como registrarBloqueo, llamarCUGenerarSismograma, tomarRechazarEvento
        // los implementaremos a medida que avancemos en el flujo completo.

        // 13 / 14 : tomarSelecEventoSismico
        public void tomarSeleccionEventoSismico(int idEvento)
        {
            // Recupera los datos del evento seleccionado
            eventoSeleccionado = buscarDatosSismiciosDeEvento(idEvento);

            // Guarda el usuario logueado actual
            usuarioLogueado = conocerUsuarioLogeado();

            // 15 : obtenerFechaHoraActual
            DateTime fechaHoraActual = obtenerFechaHoraActual();

            // 16 : buscarEstadoBloqueado
            Estado estadoBloqueado = new Estado("Bloqueado");

            // 17 : esAmbitoEventoSismico
            // 18 : esBloqueado
            if (!eventoSeleccionado.esEstadoActual(estadoBloqueado))
            {
                // 22 : registrarBloqueo
                registrarBloqueo(fechaHoraActual, estadoBloqueado);
            }

            // 27 → continúa el flujo...
        }

        // 22 : registrarBloqueo
        private void registrarBloqueo(DateTime fechaHoraActual, Estado estadoBloqueado)
        {
            // 23 : bloquear (cerrar estado actual)
            eventoSeleccionado.cerrarEstadoActual(fechaHoraActual);

            // 25 : crearCambioEstadoEvento
            CambioEstado nuevoCambio = new CambioEstado(estadoBloqueado, fechaHoraActual, usuarioLogueado);
            eventoSeleccionado.agregarCambioEstado(nuevoCambio);
        }

        // 49 : llamarCuGenerarSismograma
        public void llamarCuGenerarSismograma()
        {
            // Este método llama al caso de uso "Generar Sismograma"
            // Paso 49 : INCLUDE → llamada a otro CU
            GeneradorSismograma generador = new GeneradorSismograma();
            generador.generarSismogramaDesdeEvento(eventoSeleccionado);
            Console.WriteLine("Se invocó al CU Generar Sismograma para el evento seleccionado.");
        }

        // 55 : tomarRechazarEvento
        public void tomarRechazarEvento()
        {
            // Paso 57: Validar si el evento tiene los datos necesarios para ser rechazado
            if (!validarDatosNecesarios())
                throw new Exception("Faltan datos necesarios para rechazar el evento.");

            // Paso 58: Validar que la acción seleccionada sea rechazar
            if (!validarAccionSeleccionada("Rechazar"))
                throw new Exception("Acción seleccionada no válida.");

            // Paso 59: Fecha actual
            DateTime fechaHoraActual = obtenerFechaHoraActual();

            // Paso 60–62: Obtener estado rechazado
            Estado estadoRechazado = new Estado("Rechazado");
            if (!eventoSeleccionado.esEstadoActual(estadoRechazado))
            {
                // Paso 63: registrarRechazo
                registrarRechazo(fechaHoraActual, estadoRechazado);
            }
        }

        // 57 : validarDatosNecesarios
        private bool validarDatosNecesarios()
        {
            // Simulación de validación. En un sistema real verificaría campos del evento
            return eventoSeleccionado != null && !string.IsNullOrEmpty(eventoSeleccionado.Ubicacion);
        }

        // 58 : validarAccionSeleccionada
        private bool validarAccionSeleccionada(string accion)
        {
            // Verifica si la acción seleccionada es "Rechazar"
            return accion == "Rechazar";
        }

        // 63 : registrarRechazo
        private void registrarRechazo(DateTime fechaHoraActual, Estado estadoRechazado)
        {
            // Paso 64 : rechazar (cerrar estado actual)
            eventoSeleccionado.cerrarEstadoActual(fechaHoraActual);

            // Paso 68 : new → nuevo cambio de estado
            CambioEstado nuevoCambio = new CambioEstado(estadoRechazado, fechaHoraActual, usuarioLogueado);

            // Paso 67 : setResponsableCambio (ya se pasa en el constructor)
            eventoSeleccionado.agregarCambioEstado(nuevoCambio);
        }

        // 69 : finCU
        public void finalizarCasoDeUso()
        {
            Console.WriteLine("Fin del caso de uso: Generar Sismograma");
        }

        public List<EventoSismico> simularFlujoInicial()
        {
            // Simula la ejecución del paso 1 al 12
            List<EventoSismico> eventos = buscarEventoAutoDetectado();
            eventos.Sort((e1, e2) => e1.FechaHora.CompareTo(e2.FechaHora));
            return eventos;
        }

    }
}

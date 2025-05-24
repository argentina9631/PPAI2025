using System;
using CapaEntidades;

namespace CapaLogica
{
    public class GeneradorSismograma
    {
        public void generarSismogramaDesdeEvento(EventoSismico evento)
        {
            if (evento == null)
            {
                Console.WriteLine("No se recibió un evento válido.");
                return;
            }

            // Aquí iría la lógica real de procesamiento
            Console.WriteLine($"Generando sismograma para evento #{evento.Id}...");

            // Simulación de procesamiento
            foreach (var serie in evento.SeriesTemporales ?? new System.Collections.Generic.List<SerieTemporal>())
            {
                Console.WriteLine($"Procesando serie: {serie.Nombre} - Estación: {serie.getCodigoEstacion()}");
            }

            Console.WriteLine("Sismograma generado correctamente.");
        }
    }
}

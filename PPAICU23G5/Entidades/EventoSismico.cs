using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EventoSismico
    {
        public int Id { get; set; }
        public DateTime FechaHoraOcurrencia { get; set; }
        public CambioEstado EstadoActual { get; set; }
        public OrigenDeGeneracion Origen { get; set; }
        public ClasificacionSismo Clasificacion { get; set; }
        public Alcance Alcance { get; set; }
        public List<SerieTemporal> SeriesTemporales { get; set; }

        public CambioEstado ObtenerEstadoActual()
        {
            return EstadoActual;
        }

        public void RegistrarBloqueo(CambioEstado nuevoEstado)
        {
            EstadoActual = nuevoEstado;
        }
    }
}

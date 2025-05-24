using System.Collections.Generic;

namespace CapaEntidades
{
    public class SerieTemporal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public EstacionSismologica Estacion { get; set; }
        public Sismografo Sismografo { get; set; }
        public List<MuestraSismica> Muestras { get; set; }

        public SerieTemporal()
        {
            Muestras = new List<MuestraSismica>();
        }

        // 36 : recorerSeriesTemporales
        public List<MuestraSismica> conocerMuestras()
        {
            // Devuelve todas las muestras asociadas a la serie
            return Muestras;
        }

        // 48 : ordenarSeriesPorEstacionSismologica
        public string getCodigoEstacion()
        {
            // Devuelve el código de la estación
            return Estacion != null ? Estacion.getCodigoEstacion() : "";
        }
    }
}

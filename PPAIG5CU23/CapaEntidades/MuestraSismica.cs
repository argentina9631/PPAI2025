using System.Collections.Generic;

namespace CapaEntidades
{
    public class MuestraSismica
    {
        public List<DetalleMuestraSismica> Detalles { get; set; }

        public MuestraSismica()
        {
            Detalles = new List<DetalleMuestraSismica>();
        }

        // 38 : obtenerMuestras → ya está implicado con la propiedad

        // 39 : *conocerDatos
        public List<DetalleMuestraSismica> conocerDatos()
        {
            // Devuelve todos los detalles de esta muestra
            return Detalles;
        }
    }
}

using System.Collections.Generic;
using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockDetalleMuestraSismica
    {
        public static List<DetalleMuestraSismica> Detalles1 => new List<DetalleMuestraSismica>
        {
            new DetalleMuestraSismica(MockTipoDeDato.VelocidadDeOnda, 1.7),
            new DetalleMuestraSismica(MockTipoDeDato.FrecuenciaDeOnda, 12.3),
            new DetalleMuestraSismica(MockTipoDeDato.LongitudDeOnda, 190.5)
        };

        public static List<DetalleMuestraSismica> Detalles2 => new List<DetalleMuestraSismica>
        {
            new DetalleMuestraSismica(MockTipoDeDato.VelocidadDeOnda, 1.4),
            new DetalleMuestraSismica(MockTipoDeDato.FrecuenciaDeOnda, 9.8),
            new DetalleMuestraSismica(MockTipoDeDato.LongitudDeOnda, 205.0)
        };
    }
}

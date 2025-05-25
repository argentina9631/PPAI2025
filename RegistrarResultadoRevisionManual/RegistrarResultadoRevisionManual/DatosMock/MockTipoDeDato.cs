using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockTipoDeDato
    {
        public static TipoDeDato VelocidadDeOnda => new TipoDeDato("Velocidad de onda", "m/s", 1.5);
        public static TipoDeDato FrecuenciaDeOnda => new TipoDeDato("Frecuencia de onda", "Hz", 10.0);
        public static TipoDeDato LongitudDeOnda => new TipoDeDato("Longitud de onda", "m", 200.0);
    }
}

using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockAlcance
    {
        public static AlcanceSismo Local =>
            new AlcanceSismo("Local", "Afecta solo la zona cercana");

        public static AlcanceSismo Regional =>
            new AlcanceSismo("Regional", "Afecta una región amplia");

        public static AlcanceSismo Nacional =>
            new AlcanceSismo("Nacional", "Afecta múltiples provincias");
    }
}

using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockOrigen
    {
        public static OrigenDeGeneracion NaturalTectonico =>
            new OrigenDeGeneracion("Natural", "Evento natural tectónico");

        public static OrigenDeGeneracion Artificial =>
            new OrigenDeGeneracion("Artificial", "Evento inducido por actividad humana");

        public static OrigenDeGeneracion NaturalVolcanico =>
            new OrigenDeGeneracion("Natural", "Evento natural de origen volcánico");
    }
}

using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockClasificacion
    {
        public static ClasificacionSismo Superficial =>
            new ClasificacionSismo(0, 10, "Superficial");

        public static ClasificacionSismo Mediana =>
            new ClasificacionSismo(10, 30, "Mediana Profundidad");

        public static ClasificacionSismo Profunda =>
            new ClasificacionSismo(30, 70, "Profundo");
    }
}

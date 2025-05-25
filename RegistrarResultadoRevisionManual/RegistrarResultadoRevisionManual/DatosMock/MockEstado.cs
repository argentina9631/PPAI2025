using RegistrarResultadoRevisionManual.Entidades;
using System.Collections.Generic;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockEstado
    {
        public static List<Estado> ObtenerTodosLosEstados()
        {
            return new List<Estado>
            {
                new Estado("Bloqueado", "EventoSismico"),
                new Estado("AutoDetectado", "EventoSismico"),
                new Estado("Pendiente", "Orden"),
                new Estado("Activo", "Sismografo"),
            };
        }
    }
}

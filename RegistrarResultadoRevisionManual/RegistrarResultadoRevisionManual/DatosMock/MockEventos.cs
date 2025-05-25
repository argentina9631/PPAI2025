using System;
using System.Collections.Generic;
using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockEventos
    {
        public static List<EventoSismico> ObtenerTodosLosEventos()
        {
            return new List<EventoSismico>
            {
                new EventoSismico(
                    id: 1,
                    ubicacion: "San Juan",
                    magnitud: MockMagnitud.MagnitudBaja,
                    fechaHoraOcurrencia: DateTime.Now.AddMinutes(-50),
                    latEpicentro: -31.5375,
                    longEpicentro: -68.5364,
                    latHipocentro: -31.5432,
                    longHipocentro: -68.5400,
                    clasificacion: MockClasificacion.Mediana,
                    origen: MockOrigen.NaturalTectonico,
                    alcance: MockAlcance.Regional,
                    cambiosEstado: new List<CambioEstado>
                    {
                        new CambioEstado(
                            new Estado("AutoDetectado", "EventoSismico"),
                            DateTime.Now.AddMinutes(-30)
                        )
                    },
                    seriesTemporales: MockSerieTemporal.ObtenerSeriesMock()  // Aquí paso la lista completa
                ),

                new EventoSismico(
                    id: 2,
                    ubicacion: "Mendoza",
                    magnitud: MockMagnitud.MagnitudAlta,
                    fechaHoraOcurrencia: DateTime.Now.AddHours(-1),
                    latEpicentro: -32.8908,
                    longEpicentro: -68.8272,
                    latHipocentro: -32.8950,
                    longHipocentro: -68.8300,
                    clasificacion: MockClasificacion.Superficial,
                    origen: MockOrigen.Artificial,
                    alcance: MockAlcance.Local,
                    cambiosEstado: new List<CambioEstado>
                    {
                        new CambioEstado(
                            new Estado("Manual", "EventoSismico"),
                            DateTime.Now.AddHours(-1)
                        )
                    },
                    seriesTemporales: MockSerieTemporal.ObtenerSeriesMock()  // igual, lista mock
                ),

                new EventoSismico(
                    id: 3,
                    ubicacion: "Salta",
                    magnitud: MockMagnitud.MagnitudMedia,
                    fechaHoraOcurrencia: DateTime.Now.AddMinutes(-10),
                    latEpicentro: -24.7821,
                    longEpicentro: -65.4232,
                    latHipocentro: -24.7850,
                    longHipocentro: -65.4250,
                    clasificacion: MockClasificacion.Profunda,
                    origen: MockOrigen.NaturalVolcanico,
                    alcance: MockAlcance.Regional,
                    cambiosEstado: new List<CambioEstado>
                    {
                        new CambioEstado(
                            new Estado("AutoDetectado", "EventoSismico"),
                            DateTime.Now.AddMinutes(-10)
                        )
                    },
                    seriesTemporales: MockSerieTemporal.ObtenerSeriesMock()
                )
            };
        }
    }
}

using RegistrarResultadoRevisionManual.DatosMock;
using RegistrarResultadoRevisionManual.Entidades;
using System;
using System.Collections.Generic;

public static class MockSerieTemporal
{
    public static SerieTemporal Serie1
    {
        get
        {
            var serie = new SerieTemporal(
                "Alerta alta",
                DateTime.Now.AddMinutes(-50),
                DateTime.Now.AddMinutes(-30),
                1.0,
                MockSismografo.SismografoNorte
            );
            serie.AgregarMuestra(MockMuestraSismica.Muestra1);
            serie.AgregarMuestra(MockMuestraSismica.Muestra2);
            return serie;
        }
    }

    public static SerieTemporal Serie2
    {
        get
        {
            var serie = new SerieTemporal(
                "Alerta baja",
                DateTime.Now.AddMinutes(-45),
                DateTime.Now.AddMinutes(-15),
                0.5,
                MockSismografo.SismografoSur
            );
            serie.AgregarMuestra(MockMuestraSismica.Muestra3);
            return serie;
        }
    }

    public static SerieTemporal Serie3
    {
        get
        {
            var serie = new SerieTemporal(
                "Sin alerta",
                DateTime.Now.AddMinutes(-30),
                DateTime.Now.AddMinutes(-10),
                0.2,
                MockSismografo.SismografoEste
            );
            return serie;
        }
    }

    // Método para devolver todas las series temporales juntas
    public static List<SerieTemporal> ObtenerSeriesMock()
    {
        return new List<SerieTemporal> { Serie1, Serie2, Serie3 };
    }
}

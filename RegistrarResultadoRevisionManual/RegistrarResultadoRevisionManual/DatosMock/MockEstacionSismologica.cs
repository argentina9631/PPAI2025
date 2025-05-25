using RegistrarResultadoRevisionManual.Entidades;
using System.Collections.Generic;

public static class MockEstacionSismologica
{
    public static EstacionSismologica EstacionNorte => new EstacionSismologica(
        codigoEstacion: "N001",
        latitud: -31.5375,
        longitud: -68.5364,
        nombre: "Estación Norte"
    );

    public static EstacionSismologica EstacionSur => new EstacionSismologica(
        codigoEstacion: "S001",
        latitud: -32.8908,
        longitud: -68.8272,
        nombre: "Estación Sur"
    );

    public static EstacionSismologica EstacionEste => new EstacionSismologica(
        codigoEstacion: "E001",
        latitud: -24.7821,
        longitud: -65.4232,
        nombre: "Estación Este"
    );

    public static List<EstacionSismologica> ObtenerTodasLasEstaciones()
    {
        return new List<EstacionSismologica>
        {
            EstacionNorte,
            EstacionSur,
            EstacionEste
        };
    }
}

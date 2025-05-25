using System;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Sismografo
    {
        // Campos privados
        private DateTime fechaAdquisicion;
        private string identificadorSismografo;
        private string nroSerie;
        private EstacionSismologica estacionSismologica;

        // Constructor
        public Sismografo(DateTime fechaAdquisicion, string identificador, string nroSerie, EstacionSismologica estacion)
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.identificadorSismografo = identificador;
            this.nroSerie = nroSerie;
            this.estacionSismologica = estacion;
        }

        public string getCodigoEstacionSismologica()
        {
            return estacionSismologica.GetCodigo();
        }

    }
}

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

        // Propiedades públicas para acceso
        public DateTime FechaAdquisicion
        {
            get => fechaAdquisicion;
            set => fechaAdquisicion = value;
        }

        public string IdentificadorSismografo
        {
            get => identificadorSismografo;
            set => identificadorSismografo = value;
        }

        public string NroSerie
        {
            get => nroSerie;
            set => nroSerie = value;
        }

        public EstacionSismologica EstacionSismologica
        {
            get => estacionSismologica;
            set => estacionSismologica = value;
        }

        // Constructor
        public Sismografo(DateTime fechaAdquisicion, string identificador, string nroSerie, EstacionSismologica estacion)
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.identificadorSismografo = identificador;
            this.nroSerie = nroSerie;
            this.estacionSismologica = estacion;
        }
    }
}

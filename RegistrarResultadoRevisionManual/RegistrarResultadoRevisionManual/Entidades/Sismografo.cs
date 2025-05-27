using System;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Sismografo
    {
        //
        // ATRIBUTOS
        //
        private DateTime fechaAdquisicion;
        private string identificadorSismografo;
        private string nroSerie;
        private EstacionSismologica estacionSismologica;


        //
        // CONSTRUCTOR
        //
        public Sismografo(DateTime fechaAdquisicion, string identificador, string nroSerie, EstacionSismologica estacion)
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.identificadorSismografo = identificador;
            this.nroSerie = nroSerie;
            this.estacionSismologica = estacion;
        }


        //
        // METODOS
        //
        public string getCodigoEstacionSismologica()
        {
            return estacionSismologica.GetCodigo();
        }

    }
}

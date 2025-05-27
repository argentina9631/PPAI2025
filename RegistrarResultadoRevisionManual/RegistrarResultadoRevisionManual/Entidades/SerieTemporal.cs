using System;
using System.Collections.Generic;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class SerieTemporal
    {

        //
        // ATRIBUTOS
        //
        private string condicionAlarma;
        private DateTime fechaHoraInicioRegistroMuestras;
        private DateTime fechaHoraRegistro;
        private double frecuenciaMuestreo;
        private List<MuestraSismica> muestras;
        private Sismografo sismografo;


        //
        // CONSTRUCTOR
        //
        public SerieTemporal(string condicionAlarma, DateTime inicio, DateTime registro, double frecuencia, Sismografo sismografo)
        {
            this.condicionAlarma = condicionAlarma;
            this.fechaHoraInicioRegistroMuestras = inicio;
            this.fechaHoraRegistro = registro;
            this.frecuenciaMuestreo = frecuencia;
            this.sismografo = sismografo;
            this.muestras = new List<MuestraSismica>();
            this.sismografo = sismografo;
        }


        //
        // METODOS
        //
        public List<MuestraSismica> GetMuestras() => muestras;

        public string ConocerCodigoEstacionSismologica()
        {
            return sismografo.getCodigoEstacionSismologica();
        }

        public void AgregarMuestra(MuestraSismica muestra)
        {
            muestras.Add(muestra);
        }
    }
}

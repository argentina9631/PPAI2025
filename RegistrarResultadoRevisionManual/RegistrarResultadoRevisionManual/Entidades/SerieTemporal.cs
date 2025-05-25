using System;
using System.Collections.Generic;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class SerieTemporal
    {
        private string condicionAlarma;
        private DateTime fechaHoraInicioRegistroMuestras;
        private DateTime fechaHoraRegistro;
        private double frecuenciaMuestreo;
        private List<MuestraSismica> muestras;
        private Sismografo sismografo;

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

        public string GetCondicionAlarma() => condicionAlarma;
        public DateTime GetFechaHoraInicioRegistroMuestras() => fechaHoraInicioRegistroMuestras;
        public DateTime GetFechaHoraRegistro() => fechaHoraRegistro;
        public double GetFrecuenciaMuestreo() => frecuenciaMuestreo;
        public List<MuestraSismica> GetMuestras() => muestras;

        // Devuelve la estación asociada al sismógrafo de esta serie temporal
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

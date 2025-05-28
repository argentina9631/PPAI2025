using System;
using System.Collections.Generic;
using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockMuestraSismica
    {
        public static MuestraSismica Muestra1
        {
            get
            {
                var muestra = new MuestraSismica(DateTime.Now.AddMinutes(-45));
                foreach (var detalle in MockDetalleMuestraSismica.Detalles1)
                {
                    muestra.AgregarDetalle(detalle);
                }
                return muestra;
            }
        }

        public static MuestraSismica Muestra2
        {
            get
            {
                var muestra = new MuestraSismica(DateTime.Now.AddMinutes(-40));
                foreach (var detalle in MockDetalleMuestraSismica.Detalles2)
                {
                    muestra.AgregarDetalle(detalle);
                }
                return muestra;
            }
        }

        public static MuestraSismica Muestra3
        {
            get
            {
                var muestra = new MuestraSismica(DateTime.Now.AddMinutes(-30));
                foreach (var detalle in MockDetalleMuestraSismica.Detalles1)
                {
                    muestra.AgregarDetalle(detalle);
                }
                return muestra;
            }
        }
    }
}

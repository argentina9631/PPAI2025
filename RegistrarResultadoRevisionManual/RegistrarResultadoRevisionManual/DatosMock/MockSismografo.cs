using RegistrarResultadoRevisionManual.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockSismografo
    {
        public static Sismografo SismografoNorte => new Sismografo(
            DateTime.Now.AddDays(-10),
            "SIS-N-001",
            "12345",
            MockEstacionSismologica.EstacionNorte
        );

        public static Sismografo SismografoSur => new Sismografo(
            DateTime.Now.AddDays(-15),
            "SIS-S-001",
            "67890",
            MockEstacionSismologica.EstacionSur
        );

        public static Sismografo SismografoEste => new Sismografo(
            DateTime.Now.AddDays(-20),
            "SIS-E-001",
            "54321",
            MockEstacionSismologica.EstacionEste
        );
    }

}

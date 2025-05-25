using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrarResultadoRevisionManual.Entidades;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockMagnitud
    {
        public static MagnitudRichter MagnitudBaja => new MagnitudRichter("Baja", 3.3);
        public static MagnitudRichter MagnitudMedia => new MagnitudRichter("Media", 4.2);
        public static MagnitudRichter MagnitudAlta => new MagnitudRichter("Alta", 6.1);
    }
}

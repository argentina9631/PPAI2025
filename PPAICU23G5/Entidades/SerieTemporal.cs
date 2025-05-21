using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerieTemporal
    {
        public int Id { get; set; }
        public Sismografo Sismografo { get; set; }
        public List<MuestraSismica> Muestras { get; set; }

        public List<MuestraSismica> ObtenerMuestras()
        {
            return Muestras;
        }

        public bool SosDelSismografo(Sismografo s)
        {
            return Sismografo?.Id == s?.Id;
        }
    }
}


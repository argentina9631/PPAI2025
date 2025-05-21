using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MuestraSismica
    {
        public int Id { get; set; }
        public List<DetalleMuestraSismica> Detalles { get; set; }

        public List<DetalleMuestraSismica> ObtenerDatos()
        {
            return Detalles;
        }
    }
}


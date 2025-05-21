using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sismografo
    {
        public int Id { get; set; }
        public EstacionSismologica Estacion { get; set; }

        public EstacionSismologica ObtenerEstacionSismologica()
        {
            return Estacion;
        }
    }
}


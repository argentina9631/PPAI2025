using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class EstadoDAO
    {
        public static Estado BuscarEstadoBloqueado()
        {
            // Simulación: en la BD real harías una consulta
            return new Estado { Nombre = "Bloqueado" };
        }

        public static Estado BuscarEstadoRechazado()
        {
            return new Estado { Nombre = "Rechazado" };
        }

        public static Estado BuscarEstadoPendiente()
        {
            return new Estado { Nombre = "Pendiente de Revisión" };
        }
    }
}


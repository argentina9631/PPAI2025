//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Entidades;

namespace Logica
{
    public static class GeneradorSismograma
    {
        public static List<Tuple<double, double>> Generar(SerieTemporal serie)
        {
            var datos = new List<Tuple<double, double>>();
            double tiempo = 0;

            foreach (var muestra in serie.Muestras)
            {
                foreach (var detalle in muestra.Detalles)
                {
                    if (detalle.ObtenerTipoDeDato().Nombre == "Velocidad")
                    {
                        datos.Add(new Tuple<double, double>(tiempo, detalle.Valor));
                        tiempo += 1; // Aumenta tiempo 1 unidad por muestra. Podés ajustarlo.
                    }
                }
            }

            return datos;
        }
    }
}



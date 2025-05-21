//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public static class EventoSismicoDAO
    {
        public static List<EventoSismico> BuscarEventosPendientes()
        {
            // Simulación de datos. En versión real, conectás con la BD
            Estado pendiente = new Estado { Nombre = "Pendiente de Revisión" };

            List<EventoSismico> lista = new List<EventoSismico>
            {
                new EventoSismico
                {
                    Id = 1,
                    FechaHoraOcurrencia = DateTime.Now.AddHours(-3),
                    EstadoActual = new CambioEstado
                    {
                        FechaHoraInicio = DateTime.Now.AddHours(-3),
                        Estado = pendiente
                    },
                    Alcance = new Alcance { Nombre = "Regional" },
                    Clasificacion = new ClasificacionSismo { Nombre = "Leve" },
                    Origen = new OrigenDeGeneracion { Nombre = "Tectónico" },
                    SeriesTemporales = new List<SerieTemporal>
                    {
                        new SerieTemporal
                        {
                            Id = 1,
                            Sismografo = new Sismografo
                            {
                                Id = 101,
                                Estacion = new EstacionSismologica { Codigo = "ST001" }
                            },
                            Muestras = new List<MuestraSismica>
                            {
                                new MuestraSismica
                                {
                                    Id = 501,
                                    Detalles = new List<DetalleMuestraSismica>
                                    {
                                        new DetalleMuestraSismica
                                        {
                                            TipoDato = new TipoDeDato { Nombre = "Velocidad" },
                                            Valor = 2.3
                                        },
                                        new DetalleMuestraSismica
                                        {
                                            TipoDato = new TipoDeDato { Nombre = "Frecuencia" },
                                            Valor = 5.1
                                        }
                                    }
                                }
                            }
                        }
                    }
                },

                new EventoSismico
                {
                    Id = 2,
                    FechaHoraOcurrencia = DateTime.Now.AddHours(-7),
                    EstadoActual = new CambioEstado
                    {
                        FechaHoraInicio = DateTime.Now.AddHours(-7),
                        Estado = pendiente
                    },
                    Alcance = new Alcance { Nombre = "Regional" },
                    Clasificacion = new ClasificacionSismo { Nombre = "Leve" },
                    Origen = new OrigenDeGeneracion { Nombre = "Tectónico" },
                    SeriesTemporales = new List<SerieTemporal>() // vacía por ahora
                },

                new EventoSismico
                {
                    Id = 3,
                    FechaHoraOcurrencia = DateTime.Now.AddHours(-1),
                    EstadoActual = new CambioEstado
                    {
                        FechaHoraInicio = DateTime.Now.AddHours(-1),
                        Estado = pendiente
                    },
                    Alcance = new Alcance { Nombre = "Local" },
                    Clasificacion = new ClasificacionSismo { Nombre = "Moderado" },
                    Origen = new OrigenDeGeneracion { Nombre = "Volcánico" },
                    SeriesTemporales = new List<SerieTemporal>() // otra serie si querés
                },

                new EventoSismico
                {
                    Id = 4,
                    FechaHoraOcurrencia = DateTime.Now.AddHours(-2),
                    EstadoActual = new CambioEstado
                    {
                        FechaHoraInicio = DateTime.Now.AddHours(-2),
                        Estado = pendiente
                    },
                    Alcance = new Alcance { Nombre = "Global" },
                    Clasificacion = new ClasificacionSismo { Nombre = "Fuerte" },
                    Origen = new OrigenDeGeneracion { Nombre = "Artificial" },
                    SeriesTemporales = new List<SerieTemporal>
                        {
                            new SerieTemporal
                            {
                                Id = 2,
                                Sismografo = new Sismografo
                                {
                                    Id = 102,
                                    Estacion = new EstacionSismologica { Codigo = "ST002" }
                                },
                                Muestras = new List<MuestraSismica>
                                {
                                    new MuestraSismica
                                    {
                                        Id = 601,
                                        Detalles = new List<DetalleMuestraSismica>
                                        {
                                            new DetalleMuestraSismica
                                            {
                                                TipoDato = new TipoDeDato { Nombre = "Velocidad" },
                                                Valor = 3.2
                                            },
                                            new DetalleMuestraSismica
                                            {
                                                TipoDato = new TipoDeDato { Nombre = "Velocidad" },
                                                Valor = 4.8
                                            },
                                            new DetalleMuestraSismica
                                            {
                                                TipoDato = new TipoDeDato { Nombre = "Velocidad" },
                                                Valor = 2.7
                                            }
                                        }
                                    }
                                }
                            }
                        }
                }
            };

            return lista;
        }

        public static void ActualizarEstado(EventoSismico evento)
        {
            // Acá iría el UPDATE a base de datos
            Console.WriteLine($"Evento {evento.Id} actualizado a estado: {evento.ObtenerEstadoActual().Estado.Nombre}");
        }
    }
}


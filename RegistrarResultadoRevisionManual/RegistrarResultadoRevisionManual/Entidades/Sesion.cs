using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Sesion
    {
        //
        // ATRIBUTOS
        //
        private static Sesion instancia;
        private Usuario usuarioActual;

        private Sesion() { }

        //
        // Patrón Singleton para asegurar que solo haya una instancia de Sesion
        //
        public static Sesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Sesion();
                }
                return instancia;
            }
        }

        //
        // METODOS
        //
        public void IniciarSesion(Usuario usuario)
        {
            usuarioActual = usuario;
        }

        public Usuario ObtenerUsuarioActual()
        {
            return usuarioActual;
        }
    }
}


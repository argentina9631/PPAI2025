using RegistrarResultadoRevisionManual.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.DatosMock
{
    public static class MockUsuario
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("admin", "1234", "Administrador del sistema"),
            new Usuario("usuario1", "abcd", "Juan Pérez")
        };

        public static Usuario Autenticar(string nombreUsuario, string contrasena)
        {
            return usuarios.FirstOrDefault(usuario =>
                usuario.GetNombreUsuario() == nombreUsuario &&
                usuario.GetContrasena() == contrasena);
        }
    }
}


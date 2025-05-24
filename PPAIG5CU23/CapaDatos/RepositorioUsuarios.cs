using System.Collections.Generic;
using System.Linq;
using CapaEntidades;

namespace CapaDatos
{
    public class RepositorioUsuarios
    {
        private List<Usuario> usuarios;

        public RepositorioUsuarios()
        {
            usuarios = new List<Usuario>
            {
                new Usuario(1, "Analista Sismos"),
                new Usuario(2, "Supervisor General")
            };
        }

        // 20 : conocerUsuarioLogeado
        public Usuario obtenerUsuarioPorId(int id)
        {
            // Simula obtener al usuario actualmente logueado por ID
            return usuarios.FirstOrDefault(u => u.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarResultadoRevisionManual.Entidades
{
    public class Usuario
    {
        //
        // ATRIBUTOS
        //
        private string nombreUsuario;
        private string contrasena;
        private string nombreCompleto;


        //
        // CONSTRUCTOR
        //
        public Usuario(string nombreUsuario, string contrasena, string nombreCompleto)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.nombreCompleto = nombreCompleto;
        }


        //
        // METODOS
        //
        public string GetNombreUsuario()
        {
            return nombreUsuario;
        }

        public string GetContrasena()
        {
            return contrasena;
        }

        public string GetNombreCompleto()
        {
            return nombreCompleto;
        }
    }
}

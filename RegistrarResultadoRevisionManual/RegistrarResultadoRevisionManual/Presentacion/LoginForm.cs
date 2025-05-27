using RegistrarResultadoRevisionManual.DatosMock;
using RegistrarResultadoRevisionManual.Entidades;
using System;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            Usuario usuarioAutenticado = MockUsuario.Autenticar(usuario, contrasena);

            if (usuarioAutenticado != null)
            {
                Sesion.Instancia.IniciarSesion(usuarioAutenticado);

                MessageBox.Show($"Bienvenido {usuarioAutenticado.GetNombreCompleto()}!", "Login exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var pantallaOpciones = new PantallaOpciones();
                pantallaOpciones.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
        }
    }
}

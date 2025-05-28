using RegistrarResultadoRevisionManual.Entidades;
using RegistrarResultadoRevisionManual.LogicaNegocio;
using System;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class DetalleDelEvento : Form
    {
        //
        // ATRIBUTOS
        //
        private GestorRevisionManual gestor;


        //
        // CONSTRUCTOR
        //
        public DetalleDelEvento(string[] datosGenerales, string datosTemporales)
        {
            InitializeComponent();

            // Asignar valores a los TextBoxes
            txtMagnitud.Text = datosGenerales.Length > 0 ? datosGenerales[0] : "";
            txtAlcance.Text = datosGenerales.Length > 1 ? datosGenerales[1] : "";
            txtClasificacion.Text = datosGenerales.Length > 2 ? datosGenerales[2] : "";
            txtOrigen.Text = datosGenerales.Length > 3 ? datosGenerales[3] : "";
            txtDatosTemporales.Text = datosTemporales ?? "";
            txtEditableMagnitud.Text = datosGenerales.Length > 0 ? datosGenerales[0] : "";
            txtEditableAlcance.Text = datosGenerales.Length > 1 ? datosGenerales[1] : "";
            txtEditableOrigen.Text = datosGenerales.Length > 3 ? datosGenerales[3] : "";

            // Mostrar u ocultar el botón del mapa según preferencia
            btnMostrarMapa.Visible = true;

            // Asociar eventos a los botones
            btnConfirmar.Click += BtnConfirmar_Click;
            btnRechazar.Click += tomarOpcRechazarEvento;
            btnSolicitarRevision.Click += BtnSolicitarRevision_Click;
            btnMostrarMapa.Click += BtnMostrarMapa_Click;
        }


        //
        // METODOS
        //
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento confirmado.");
            this.Close();
        }

        private void tomarOpcRechazarEvento(object sender, EventArgs e)
        {
            try
            {
                gestor.tomarRechazarEvento();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al rechazar el evento:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSolicitarRevision_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Revisión solicitada a experto.");
            this.Close();
        }

        private void BtnMostrarMapa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se mostraría el mapa.");
        }

        public void SetGestor(GestorRevisionManual gestor)
        {
            this.gestor = gestor;
        }

        private void lblDatosTemporales_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

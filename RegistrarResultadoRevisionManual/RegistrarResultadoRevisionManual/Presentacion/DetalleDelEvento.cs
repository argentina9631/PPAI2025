using RegistrarResultadoRevisionManual.Entidades;
using RegistrarResultadoRevisionManual.LogicaNegocio;
using System;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class DetalleDelEvento : Form
    {
        private GestorRevisionManual gestor;

        public DetalleDelEvento(string[] datosGenerales, string datosTemporales)
        {
            InitializeComponent();

            // Configurar TextBoxes como solo lectura para evitar edición
            txtMagnitud.ReadOnly = true;
            txtAlcance.ReadOnly = true;
            txtClasificacion.ReadOnly = true;
            txtOrigen.ReadOnly = true;
            txtDatosTemporales.ReadOnly = true;

            txtDatosTemporales.Multiline = true;
            txtDatosTemporales.ScrollBars = ScrollBars.Vertical;

            // Asignar valores a los TextBoxes
            txtMagnitud.Text = datosGenerales.Length > 0 ? datosGenerales[0] : "";
            txtAlcance.Text = datosGenerales.Length > 1 ? datosGenerales[1] : "";
            txtClasificacion.Text = datosGenerales.Length > 2 ? datosGenerales[2] : "";
            txtOrigen.Text = datosGenerales.Length > 3 ? datosGenerales[3] : "";

            txtDatosTemporales.Text = datosTemporales ?? "";

            // Cargar datos en el DataGridView
            CargarDatosEventoEnTabla(datosGenerales);

            // Mostrar u ocultar el botón del mapa según preferencia
            btnMostrarMapa.Visible = true;

            // Asociar eventos a los botones
            btnConfirmar.Click += BtnConfirmar_Click;
            btnRechazar.Click += tomarOpcRechazarEvento;
            btnSolicitarRevision.Click += BtnSolicitarRevision_Click;
            btnMostrarMapa.Click += BtnMostrarMapa_Click;
        }

        private void CargarDatosEventoEnTabla(string[] datosGenerales)
        {
            dgvDatosEvento.Columns.Clear();
            dgvDatosEvento.Columns.Add("Campo", "Campo");
            dgvDatosEvento.Columns.Add("Valor", "Valor");

            dgvDatosEvento.Rows.Clear();

            if (datosGenerales.Length > 0)
                dgvDatosEvento.Rows.Add("Magnitud", datosGenerales[0]);
            if (datosGenerales.Length > 1)
                dgvDatosEvento.Rows.Add("Alcance", datosGenerales[1]);
            if (datosGenerales.Length > 3)
                dgvDatosEvento.Rows.Add("Origen", datosGenerales[3]);
        }

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
                MessageBox.Show("Evento rechazado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

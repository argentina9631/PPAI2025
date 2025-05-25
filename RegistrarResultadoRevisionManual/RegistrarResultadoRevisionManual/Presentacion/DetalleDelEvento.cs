using RegistrarResultadoRevisionManual.Entidades;
using System;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class DetalleDelEvento : Form
    {
        public DetalleDelEvento(string textoDatos, EventoSismico evento)
        {
            InitializeComponent();

            txtDatosSismicos.Text = textoDatos;

            // Cargar datos en el DataGridView
            CargarDatosEventoEnTabla(evento);

            // Mostrar mapa? (puede estar oculto si AS no quiere)
            btnMostrarMapa.Visible = true; // o false si AS no quiere

            // Asociar eventos a botones
            btnConfirmar.Click += BtnConfirmar_Click;
            btnRechazar.Click += BtnRechazar_Click;
            btnSolicitarRevision.Click += BtnSolicitarRevision_Click;
            btnMostrarMapa.Click += BtnMostrarMapa_Click;
        }

        private void CargarDatosEventoEnTabla(EventoSismico evento)
        {
            // Configurar columnas
            dgvDatosEvento.Columns.Clear();
            dgvDatosEvento.Columns.Add("Campo", "Campo");
            dgvDatosEvento.Columns.Add("Valor", "Valor");

            dgvDatosEvento.Rows.Clear();

            // Agregar filas con datos
            dgvDatosEvento.Rows.Add("Magnitud", evento.GetMagnitud().ToString());
            dgvDatosEvento.Rows.Add("Alcance", evento.GetAlcance());
            dgvDatosEvento.Rows.Add("Origen", evento.GetOrigen());

            // Opcional: hacer la tabla de solo lectura para evitar modificaciones
            dgvDatosEvento.ReadOnly = true;
        }

        // Eventos botones
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento confirmado.");
            this.Close();
        }

        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento rechazado.");
            this.Close();
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
    }
}

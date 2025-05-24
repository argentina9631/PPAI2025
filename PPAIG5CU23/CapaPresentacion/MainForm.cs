using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class MainForm : Form
    {
        private GestorRevisionManual gestor;
        private List<EventoSismico> eventos;
        private Button btnRegistrarObservacion;
        private DataGridView dgvEventos;
        private Label lblSeleccionado;
        private Button btnRechazarEvento;
        private Button btnFinalizarCU;
        private Button btnGenerarSismograma;
        private EventoSismico eventoSeleccionado;

        public MainForm()
        {
            InitializeComponent();
            gestor = new GestorRevisionManual();
            eventos = new List<EventoSismico>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Configura la grilla
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.Columns.Add("Id", "ID");
            dgvEventos.Columns.Add("FechaHora", "Fecha y Hora");
            dgvEventos.Columns.Add("Ubicacion", "Ubicación");
            dgvEventos.Columns.Add("Magnitud", "Magnitud");
        }

        // Simula paso 1 → registrar resultado de observación
        private void btnRegistrarObservacion_Click(object sender, EventArgs e)
        {
            eventos = gestor.simularFlujoInicial();

            dgvEventos.Rows.Clear();
            foreach (var ev in eventos)
            {
                dgvEventos.Rows.Add(ev.Id, ev.FechaHora, ev.Ubicacion, ev.Magnitud);
            }
        }

        // Paso 13 → seleccionar evento sísmico
        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idEvento = (int)dgvEventos.Rows[e.RowIndex].Cells["Id"].Value;
                gestor.tomarSeleccionEventoSismico(idEvento);
                eventoSeleccionado = eventos.Find(ev => ev.Id == idEvento);

                lblSeleccionado.Text = $"Evento seleccionado: {eventoSeleccionado.Id}";
            }
        }

        // Paso 55 → rechazar evento
        private void btnRechazarEvento_Click(object sender, EventArgs e)
        {
            if (eventoSeleccionado != null)
            {
                gestor.tomarRechazarEvento();
                MessageBox.Show("Evento rechazado correctamente.");
            }
        }

        // Paso 69 → fin del caso de uso
        private void btnFinalizarCU_Click(object sender, EventArgs e)
        {
            gestor.finalizarCasoDeUso();
            MessageBox.Show("Fin del caso de uso.");
        }

        private void InitializeComponent()
        {
            this.btnRegistrarObservacion = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnRechazarEvento = new System.Windows.Forms.Button();
            this.btnFinalizarCU = new System.Windows.Forms.Button();
            this.btnGenerarSismograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarObservacion
            // 
            this.btnRegistrarObservacion.Location = new System.Drawing.Point(13, 13);
            this.btnRegistrarObservacion.Name = "btnRegistrarObservacion";
            this.btnRegistrarObservacion.Size = new System.Drawing.Size(104, 56);
            this.btnRegistrarObservacion.TabIndex = 0;
            this.btnRegistrarObservacion.Text = "Registrar Observación";
            this.btnRegistrarObservacion.UseVisualStyleBackColor = true;
            this.btnRegistrarObservacion.Click += new System.EventHandler(this.btnRegistrarObservacion_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(123, 12);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(240, 150);
            this.dgvEventos.TabIndex = 1;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(369, 13);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccionado.TabIndex = 2;
            this.lblSeleccionado.Text = "label1";
            // 
            // btnRechazarEvento
            // 
            this.btnRechazarEvento.Location = new System.Drawing.Point(432, 13);
            this.btnRechazarEvento.Name = "btnRechazarEvento";
            this.btnRechazarEvento.Size = new System.Drawing.Size(105, 56);
            this.btnRechazarEvento.TabIndex = 3;
            this.btnRechazarEvento.Text = "Rechazar Evento";
            this.btnRechazarEvento.UseVisualStyleBackColor = true;
            this.btnRechazarEvento.Click += new System.EventHandler(this.btnRechazarEvento_Click);
            // 
            // btnFinalizarCU
            // 
            this.btnFinalizarCU.Location = new System.Drawing.Point(544, 13);
            this.btnFinalizarCU.Name = "btnFinalizarCU";
            this.btnFinalizarCU.Size = new System.Drawing.Size(106, 56);
            this.btnFinalizarCU.TabIndex = 4;
            this.btnFinalizarCU.Text = "Finalizar Caso de Uso";
            this.btnFinalizarCU.UseVisualStyleBackColor = true;
            this.btnFinalizarCU.Click += new System.EventHandler(this.btnFinalizarCU_Click);
            // 
            // btnGenerarSismograma
            // 
            this.btnGenerarSismograma.Location = new System.Drawing.Point(657, 13);
            this.btnGenerarSismograma.Name = "btnGenerarSismograma";
            this.btnGenerarSismograma.Size = new System.Drawing.Size(97, 56);
            this.btnGenerarSismograma.TabIndex = 6;
            this.btnGenerarSismograma.Text = "Generar Sismograma";
            this.btnGenerarSismograma.UseVisualStyleBackColor = true;
            this.btnGenerarSismograma.Click += new System.EventHandler(this.btnGenerarSismograma_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1302, 607);
            this.Controls.Add(this.btnGenerarSismograma);
            this.Controls.Add(this.btnFinalizarCU);
            this.Controls.Add(this.btnRechazarEvento);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.btnRegistrarObservacion);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //para conectar a la pantalla el c.u. de simograma
        private void btnGenerarSismograma_Click(object sender, EventArgs e)
        {
            if (eventoSeleccionado != null)
            {
                gestor.llamarCuGenerarSismograma();
                MessageBox.Show("Sismograma generado (simulado).");
            }
        }

    }
}

using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    partial class DetalleDelEvento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Quitamos los TextBox individuales y agregamos el DataGridView
        private System.Windows.Forms.TextBox txtDatosSismicos;
        private System.Windows.Forms.DataGridView dgvDatosEvento;

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnSolicitarRevision;
        private System.Windows.Forms.Button btnMostrarMapa;

        private void InitializeComponent()
        {
            this.txtDatosSismicos = new System.Windows.Forms.TextBox();
            this.dgvDatosEvento = new System.Windows.Forms.DataGridView();

            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnSolicitarRevision = new System.Windows.Forms.Button();
            this.btnMostrarMapa = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEvento)).BeginInit();

            // 
            // txtDatosSismicos
            // 
            this.txtDatosSismicos.Location = new System.Drawing.Point(12, 12);
            this.txtDatosSismicos.Multiline = true;
            this.txtDatosSismicos.Name = "txtDatosSismicos";
            this.txtDatosSismicos.ReadOnly = true;
            this.txtDatosSismicos.ScrollBars = ScrollBars.Vertical;
            this.txtDatosSismicos.Size = new System.Drawing.Size(560, 150);
            this.txtDatosSismicos.TabIndex = 0;
            this.txtDatosSismicos.Font = new System.Drawing.Font("Consolas", 10);

            // 
            // dgvDatosEvento
            // 
            this.dgvDatosEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEvento.Location = new System.Drawing.Point(12, 180);
            this.dgvDatosEvento.Name = "dgvDatosEvento";
            this.dgvDatosEvento.Size = new System.Drawing.Size(560, 80);
            this.dgvDatosEvento.TabIndex = 1;
            this.dgvDatosEvento.AllowUserToAddRows = false;
            this.dgvDatosEvento.AllowUserToDeleteRows = false;
            this.dgvDatosEvento.ReadOnly = false; // Habilitar edición si querés modificar datos
            this.dgvDatosEvento.RowHeadersVisible = false;
            this.dgvDatosEvento.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgvDatosEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 280);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.Text = "Confirmar";

            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(130, 280);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(100, 30);
            this.btnRechazar.Text = "Rechazar";

            // 
            // btnSolicitarRevision
            // 
            this.btnSolicitarRevision.Location = new System.Drawing.Point(250, 280);
            this.btnSolicitarRevision.Name = "btnSolicitarRevision";
            this.btnSolicitarRevision.Size = new System.Drawing.Size(150, 30);
            this.btnSolicitarRevision.Text = "Solicitar Revisión";

            // 
            // btnMostrarMapa
            // 
            this.btnMostrarMapa.Location = new System.Drawing.Point(420, 280);
            this.btnMostrarMapa.Name = "btnMostrarMapa";
            this.btnMostrarMapa.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarMapa.Text = "Mostrar Mapa";

            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.txtDatosSismicos);
            this.Controls.Add(this.dgvDatosEvento);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnSolicitarRevision);
            this.Controls.Add(this.btnMostrarMapa);
            this.Name = "DetalleDelEvento";
            this.Text = "Detalle del Evento Sísmico";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEvento)).EndInit();
        }

        #endregion
    }
}

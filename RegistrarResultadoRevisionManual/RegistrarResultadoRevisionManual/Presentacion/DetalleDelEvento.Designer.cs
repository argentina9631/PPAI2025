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

        private TextBox txtMagnitud;
        private TextBox txtAlcance;
        private TextBox txtClasificacion;
        private TextBox txtOrigen;
        private TextBox txtDatosTemporales;

        private Label lblMagnitud;
        private Label lblAlcance;
        private Label lblClasificacion;
        private Label lblOrigen;
        private Label lblDatosTemporales;

        private DataGridView dgvDatosEvento;

        private Button btnConfirmar;
        private Button btnRechazar;
        private Button btnSolicitarRevision;
        private Button btnMostrarMapa;

        private void InitializeComponent()
        {
            this.txtMagnitud = new TextBox();
            this.txtAlcance = new TextBox();
            this.txtClasificacion = new TextBox();
            this.txtOrigen = new TextBox();
            this.txtDatosTemporales = new TextBox();

            this.lblMagnitud = new Label();
            this.lblAlcance = new Label();
            this.lblClasificacion = new Label();
            this.lblOrigen = new Label();
            this.lblDatosTemporales = new Label();

            this.dgvDatosEvento = new DataGridView();

            this.btnConfirmar = new Button();
            this.btnRechazar = new Button();
            this.btnSolicitarRevision = new Button();
            this.btnMostrarMapa = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEvento)).BeginInit();

            // 
            // Labels
            // 
            this.lblMagnitud.AutoSize = true;
            this.lblMagnitud.Location = new System.Drawing.Point(20, 20);
            this.lblMagnitud.Name = "lblMagnitud";
            this.lblMagnitud.Size = new System.Drawing.Size(67, 17);
            this.lblMagnitud.Text = "Magnitud:";

            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(20, 60);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(60, 17);
            this.lblAlcance.Text = "Alcance:";

            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(220, 20);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(85, 17);
            this.lblClasificacion.Text = "Clasificación:";

            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(220, 60);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(52, 17);
            this.lblOrigen.Text = "Origen:";

            this.lblDatosTemporales.AutoSize = true;
            this.lblDatosTemporales.Location = new System.Drawing.Point(20, 110);
            this.lblDatosTemporales.Name = "lblDatosTemporales";
            this.lblDatosTemporales.Size = new System.Drawing.Size(127, 17);
            this.lblDatosTemporales.Text = "Datos Temporales:";

            // 
            // TextBoxes
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(100, 17);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.ReadOnly = true;
            this.txtMagnitud.Size = new System.Drawing.Size(100, 22);
            this.txtMagnitud.TabIndex = 0;

            this.txtAlcance.Location = new System.Drawing.Point(100, 57);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ReadOnly = true;
            this.txtAlcance.Size = new System.Drawing.Size(100, 22);
            this.txtAlcance.TabIndex = 1;

            this.txtClasificacion.Location = new System.Drawing.Point(310, 17);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.ReadOnly = true;
            this.txtClasificacion.Size = new System.Drawing.Size(100, 22);
            this.txtClasificacion.TabIndex = 2;

            this.txtOrigen.Location = new System.Drawing.Point(310, 57);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(100, 22);
            this.txtOrigen.TabIndex = 3;

            this.txtDatosTemporales.Location = new System.Drawing.Point(20, 130);
            this.txtDatosTemporales.Multiline = true;
            this.txtDatosTemporales.Name = "txtDatosTemporales";
            this.txtDatosTemporales.ReadOnly = true;
            this.txtDatosTemporales.ScrollBars = ScrollBars.Vertical;
            this.txtDatosTemporales.Size = new System.Drawing.Size(390, 80);
            this.txtDatosTemporales.TabIndex = 4;

            // 
            // DataGridView
            // 
            this.dgvDatosEvento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEvento.Location = new System.Drawing.Point(20, 230);
            this.dgvDatosEvento.Name = "dgvDatosEvento";
            this.dgvDatosEvento.Size = new System.Drawing.Size(390, 100);
            this.dgvDatosEvento.TabIndex = 5;
            this.dgvDatosEvento.AllowUserToAddRows = false;
            this.dgvDatosEvento.AllowUserToDeleteRows = false;
            this.dgvDatosEvento.ReadOnly = true;
            this.dgvDatosEvento.RowHeadersVisible = false;
            this.dgvDatosEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // Buttons
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(20, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmar.Text = "Confirmar";

            this.btnRechazar.Location = new System.Drawing.Point(120, 350);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(90, 30);
            this.btnRechazar.Text = "Rechazar";

            this.btnSolicitarRevision.Location = new System.Drawing.Point(220, 350);
            this.btnSolicitarRevision.Name = "btnSolicitarRevision";
            this.btnSolicitarRevision.Size = new System.Drawing.Size(120, 30);
            this.btnSolicitarRevision.Text = "Solicitar Revisión";

            this.btnMostrarMapa.Location = new System.Drawing.Point(350, 350);
            this.btnMostrarMapa.Name = "btnMostrarMapa";
            this.btnMostrarMapa.Size = new System.Drawing.Size(120, 30);
            this.btnMostrarMapa.Text = "Mostrar Mapa";

            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblMagnitud);
            this.Controls.Add(this.txtMagnitud);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblDatosTemporales);
            this.Controls.Add(this.txtDatosTemporales);
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

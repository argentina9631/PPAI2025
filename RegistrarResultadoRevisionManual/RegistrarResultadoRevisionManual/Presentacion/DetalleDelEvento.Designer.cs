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
        // TextBox para los datos editables
        private TextBox txtEditableMagnitud;
        private TextBox txtEditableAlcance;
        private TextBox txtEditableOrigen;

        private Label lblMagnitud;
        private Label lblAlcance;
        private Label lblClasificacion;
        private Label lblOrigen;
        private DataGridViewButtonColumn DataGridViewButtonColumn;

        private Button btnConfirmar;
        private Button btnRechazar;
        private Button btnSolicitarRevision;
        private Button btnMostrarMapa;

        private void InitializeComponent()
        {
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDatosTemporales = new System.Windows.Forms.TextBox();
            this.txtEditableMagnitud = new System.Windows.Forms.TextBox();
            this.txtEditableAlcance = new System.Windows.Forms.TextBox();
            this.txtEditableOrigen = new System.Windows.Forms.TextBox();
            this.lblMagnitud = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnSolicitarRevision = new System.Windows.Forms.Button();
            this.btnMostrarMapa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(63, 33);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.ReadOnly = true;
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 0;
            // 
            // txtAlcance
            // 
            this.txtAlcance.Location = new System.Drawing.Point(63, 86);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.ReadOnly = true;
            this.txtAlcance.Size = new System.Drawing.Size(100, 20);
            this.txtAlcance.TabIndex = 1;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(326, 33);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.ReadOnly = true;
            this.txtClasificacion.Size = new System.Drawing.Size(100, 20);
            this.txtClasificacion.TabIndex = 2;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(326, 86);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 3;
            // 
            // txtDatosTemporales
            // 
            this.txtDatosTemporales.Location = new System.Drawing.Point(21, 169);
            this.txtDatosTemporales.Multiline = true;
            this.txtDatosTemporales.Name = "txtDatosTemporales";
            this.txtDatosTemporales.ReadOnly = true;
            this.txtDatosTemporales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatosTemporales.Size = new System.Drawing.Size(431, 167);
            this.txtDatosTemporales.TabIndex = 4;
            // 
            // txtEditableMagnitud
            // 
            this.txtEditableMagnitud.Location = new System.Drawing.Point(9, 62);
            this.txtEditableMagnitud.Multiline = true;
            this.txtEditableMagnitud.Name = "txtEditableMagnitud";
            this.txtEditableMagnitud.Size = new System.Drawing.Size(100, 22);
            this.txtEditableMagnitud.TabIndex = 6;
            // 
            // txtEditableAlcance
            // 
            this.txtEditableAlcance.Location = new System.Drawing.Point(179, 410);
            this.txtEditableAlcance.Multiline = true;
            this.txtEditableAlcance.Name = "txtEditableAlcance";
            this.txtEditableAlcance.Size = new System.Drawing.Size(100, 22);
            this.txtEditableAlcance.TabIndex = 8;
            // 
            // txtEditableOrigen
            // 
            this.txtEditableOrigen.Location = new System.Drawing.Point(326, 62);
            this.txtEditableOrigen.Multiline = true;
            this.txtEditableOrigen.Name = "txtEditableOrigen";
            this.txtEditableOrigen.Size = new System.Drawing.Size(100, 22);
            this.txtEditableOrigen.TabIndex = 10;
            // 
            // lblMagnitud
            // 
            this.lblMagnitud.AutoSize = true;
            this.lblMagnitud.Location = new System.Drawing.Point(6, 36);
            this.lblMagnitud.Name = "lblMagnitud";
            this.lblMagnitud.Size = new System.Drawing.Size(54, 13);
            this.lblMagnitud.TabIndex = 0;
            this.lblMagnitud.Text = "Magnitud:";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(6, 89);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(49, 13);
            this.lblAlcance.TabIndex = 1;
            this.lblAlcance.Text = "Alcance:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(236, 36);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 2;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(236, 89);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(20, 463);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(116, 463);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(90, 30);
            this.btnRechazar.TabIndex = 7;
            this.btnRechazar.Text = "Rechazar";
            // 
            // btnSolicitarRevision
            // 
            this.btnSolicitarRevision.Location = new System.Drawing.Point(212, 463);
            this.btnSolicitarRevision.Name = "btnSolicitarRevision";
            this.btnSolicitarRevision.Size = new System.Drawing.Size(120, 30);
            this.btnSolicitarRevision.TabIndex = 8;
            this.btnSolicitarRevision.Text = "Solicitar Revisión";
            // 
            // btnMostrarMapa
            // 
            this.btnMostrarMapa.Location = new System.Drawing.Point(338, 463);
            this.btnMostrarMapa.Name = "btnMostrarMapa";
            this.btnMostrarMapa.Size = new System.Drawing.Size(120, 30);
            this.btnMostrarMapa.TabIndex = 9;
            this.btnMostrarMapa.Text = "Mostrar Mapa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Magnitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alcance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Origen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMagnitud);
            this.groupBox1.Controls.Add(this.txtMagnitud);
            this.groupBox1.Controls.Add(this.lblAlcance);
            this.groupBox1.Controls.Add(this.txtAlcance);
            this.groupBox1.Controls.Add(this.lblClasificacion);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Controls.Add(this.txtClasificacion);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEditableOrigen);
            this.groupBox2.Controls.Add(this.txtEditableMagnitud);
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 109);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Editables";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 192);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Temporales";
            // 
            // DetalleDelEvento
            // 
            this.ClientSize = new System.Drawing.Size(470, 505);
            this.Controls.Add(this.txtDatosTemporales);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnSolicitarRevision);
            this.Controls.Add(this.btnMostrarMapa);
            this.Controls.Add(this.txtEditableAlcance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "DetalleDelEvento";
            this.Text = "Detalle del Evento Sísmico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}

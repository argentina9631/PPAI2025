namespace CapaPresentacion
{
    partial class PantallaRevisionManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.txtFechaHora = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizarMapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(13, 171);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(240, 150);
            this.dgvEventos.TabIndex = 0;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(260, 186);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 1;
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(383, 185);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 2;
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.Location = new System.Drawing.Point(490, 186);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(200, 20);
            this.txtFechaHora.TabIndex = 3;
            // 
            // btnVisualizarMapa
            // 
            this.btnVisualizarMapa.Location = new System.Drawing.Point(697, 182);
            this.btnVisualizarMapa.Name = "btnVisualizarMapa";
            this.btnVisualizarMapa.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarMapa.TabIndex = 4;
            this.btnVisualizarMapa.Text = "button1";
            this.btnVisualizarMapa.UseVisualStyleBackColor = true;
            // 
            // PantallaRevisionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizarMapa);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.txtMagnitud);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.dgvEventos);
            this.Name = "PantallaRevisionManual";
            this.Text = "PantallaRevisionManual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.DateTimePicker txtFechaHora;
        private System.Windows.Forms.Button btnVisualizarMapa;
    }
}
namespace RegistrarResultadoRevisionManual.Presentacion
{
    partial class PantallaOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpcRegResultadoObservacion;
        private System.Windows.Forms.Button btnOpcModificarEventoSismico;
        private System.Windows.Forms.Button btnOpcConsultarEventoSismico;
        private System.Windows.Forms.Button btnOpcConsultarMagnitudDeSismo;
        private System.Windows.Forms.Button btnOpcCerrarEventoSismico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRegResultado;
        private System.Windows.Forms.ToolStripMenuItem menuModificarEvento;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarEvento;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarMagnitud;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarEvento;

        // Panel para mostrar los formularios hijos
        private System.Windows.Forms.Panel panelContenedor;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaOpciones));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRegResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarMagnitud = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegResultado,
            this.menuModificarEvento,
            this.menuConsultarEvento,
            this.menuConsultarMagnitud,
            this.menuCerrarEvento});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRegResultado
            // 
            this.menuRegResultado.Name = "menuRegResultado";
            this.menuRegResultado.Size = new System.Drawing.Size(290, 25);
            this.menuRegResultado.Text = "Registrar resultado de revisión manual";
            // 
            // menuModificarEvento
            // 
            this.menuModificarEvento.Name = "menuModificarEvento";
            this.menuModificarEvento.Size = new System.Drawing.Size(195, 25);
            this.menuModificarEvento.Text = "Modificar evento sísmico";
            // 
            // menuConsultarEvento
            // 
            this.menuConsultarEvento.Name = "menuConsultarEvento";
            this.menuConsultarEvento.Size = new System.Drawing.Size(196, 25);
            this.menuConsultarEvento.Text = "Consultar evento sísmico";
            // 
            // menuConsultarMagnitud
            // 
            this.menuConsultarMagnitud.Name = "menuConsultarMagnitud";
            this.menuConsultarMagnitud.Size = new System.Drawing.Size(226, 25);
            this.menuConsultarMagnitud.Text = "Consultar magnitud de sismo";
            // 
            // menuCerrarEvento
            // 
            this.menuCerrarEvento.Name = "menuCerrarEvento";
            this.menuCerrarEvento.Size = new System.Drawing.Size(173, 25);
            this.menuCerrarEvento.Text = "Cerrar evento sísmico";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 41);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 559);
            this.panelContenedor.TabIndex = 1;
            // 
            // PantallaOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaOpciones";
            this.Text = "Opciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

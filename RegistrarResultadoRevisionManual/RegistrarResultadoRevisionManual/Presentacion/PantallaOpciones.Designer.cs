namespace RegistrarResultadoRevisionManual.Presentacion
{
    partial class PantallaOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnOpcRegResultadoObservacion;

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
            this.btnOpcRegResultadoObservacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpcRegResultadoObservacion
            // 
            this.btnOpcRegResultadoObservacion.Location = new System.Drawing.Point(30, 30);
            this.btnOpcRegResultadoObservacion.Name = "btnOpcRegResultadoObservacion";
            this.btnOpcRegResultadoObservacion.Size = new System.Drawing.Size(200, 40);
            this.btnOpcRegResultadoObservacion.TabIndex = 0;
            this.btnOpcRegResultadoObservacion.Text = "Registrar Observación";
            this.btnOpcRegResultadoObservacion.UseVisualStyleBackColor = true;
            // 
            // PantallaRevisionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpcRegResultadoObservacion);
            this.Name = "PantallaRevisionManual";
            this.Text = "PantallaRevisionManual";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

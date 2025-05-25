namespace RegistrarResultadoRevisionManual.Presentacion
{
    partial class PantallaRegistrarRevisionManual
    {
        private System.Windows.Forms.Button btnSeleccionar;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ListBox para mostrar eventos sismicos
        /// </summary>
        private System.Windows.Forms.ListBox listBoxEventos;

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
            this.components = new System.ComponentModel.Container();
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.ItemHeight = 16;
            this.listBoxEventos.Location = new System.Drawing.Point(12, 12);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(776, 404);
            this.listBoxEventos.TabIndex = 0;
            this.listBoxEventos.SelectedIndexChanged += new System.EventHandler(this.listBoxEventos_SelectedIndexChanged);

            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 430);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(150, 30);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.TomarSeleccionEvento);

            // 
            // PantallaRegistrarRevisionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.listBoxEventos);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "PantallaRegistrarRevisionManual";
            this.Text = "PantallaRegistrarRevisionManual";
            this.ResumeLayout(false);
        }


        #endregion
    }
}

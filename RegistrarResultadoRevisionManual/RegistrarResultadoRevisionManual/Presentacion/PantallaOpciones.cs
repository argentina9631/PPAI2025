using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class PantallaOpciones : Form
    {

        //
        // CONSTRUCTOR
        //
        public PantallaOpciones()
        {
            InitializeComponent();
            menuRegResultado.Click += opcRegistrarResultadoRevisionManual;
            menuModificarEvento.Click += (s, e) => MessageBox.Show("Funcionalidad no implementada aún.");
            menuConsultarEvento.Click += (s, e) => MessageBox.Show("Funcionalidad no implementada aún.");
            menuConsultarMagnitud.Click += (s, e) => MessageBox.Show("Funcionalidad no implementada aún.");
            menuCerrarEvento.Click += (s, e) => MessageBox.Show("Funcionalidad no implementada aún.");

        }


        //
        // METODOS
        //
        private void opcRegistrarResultadoRevisionManual(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            var pantallaRevision = new PantallaRegistrarRevisionManual();
            pantallaRevision.TopLevel = false;
            pantallaRevision.FormBorderStyle = FormBorderStyle.None;

            panelContenedor.Controls.Add(pantallaRevision);
            pantallaRevision.Show();
        }




    }
}

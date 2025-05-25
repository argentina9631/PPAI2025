using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RegistrarResultadoRevisionManual.LogicaNegocio;
using RegistrarResultadoRevisionManual.Entidades; // Asegurate que este sea el namespace correcto para EventoSismico

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class PantallaOpciones : Form
    {
        private GestorRevisionManual gestor;

        public PantallaOpciones()
        {
            InitializeComponent();
            gestor = new GestorRevisionManual();

            // Asociamos el evento Click del botón
            btnOpcRegResultadoObservacion.Click += BtnOpcRegResultadoObservacion_Click;
        }

        private void BtnOpcRegResultadoObservacion_Click(object sender, EventArgs e)
        {
            // Ahora retorna una lista de eventos
            List<EventoSismico> eventos = gestor.OpcRegResultadoObservacion();
            habilitarPantallaRevisionManual(eventos);
        }

        public void habilitarPantallaRevisionManual(List<EventoSismico> eventos)
        {
            PantallaRegistrarRevisionManual pantallaRevision = new PantallaRegistrarRevisionManual(eventos, gestor);
            pantallaRevision.Show();
            this.Hide();
        }
    }
}

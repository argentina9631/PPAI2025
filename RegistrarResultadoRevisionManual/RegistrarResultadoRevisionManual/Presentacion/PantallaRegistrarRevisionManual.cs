using RegistrarResultadoRevisionManual.Entidades;
using RegistrarResultadoRevisionManual.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class PantallaRegistrarRevisionManual : Form
    {
        private GestorRevisionManual gestor;
        private List<EventoSismico> eventos;

        public PantallaRegistrarRevisionManual(List<EventoSismico> eventosAutoDetectados, GestorRevisionManual gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.eventos = eventosAutoDetectados;

            foreach (var evento in eventosAutoDetectados)
            {
                listBoxEventos.Items.Add(evento.getDatos());
            }
        }

        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No hacemos nada aquí
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (listBoxEventos.SelectedIndex >= 0)
            {
                var eventoSeleccionado = eventos[listBoxEventos.SelectedIndex];
                gestor.TomarSelecEventoSismico(eventoSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un evento primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

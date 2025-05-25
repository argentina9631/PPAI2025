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
        private List<EventoSismico> eventosOrdenados;

        public PantallaRegistrarRevisionManual(GestorRevisionManual gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.eventosOrdenados = gestor.OpcRegResultadoObservacion();

            mostrarDatosOrdenados();
        }


        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No hacemos nada aquí
        }

        private void TomarSeleccionEvento(object sender, EventArgs e)
        {
            if (listBoxEventos.SelectedIndex >= 0)
            {
                var eventoSeleccionado = eventosOrdenados[listBoxEventos.SelectedIndex];
                gestor.TomarSelecEventoSismico(eventoSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un evento primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mostrarDatosOrdenados()
        {
            listBoxEventos.Items.Clear();

            foreach (var evento in eventosOrdenados)
            {
                listBoxEventos.Items.Add(evento.getDatos());
            }
        }

    }
}

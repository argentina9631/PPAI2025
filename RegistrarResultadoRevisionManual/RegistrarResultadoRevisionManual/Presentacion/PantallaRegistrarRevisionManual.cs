using RegistrarResultadoRevisionManual.Entidades;
using RegistrarResultadoRevisionManual.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrarResultadoRevisionManual.Presentacion
{
    public partial class PantallaRegistrarRevisionManual : Form
    {
        //
        // ATRIBUTOS
        //
        private GestorRevisionManual gestor;
        private List<EventoSismico> eventosOrdenados;

        //
        // CONSTRUCTOR
        //
        public PantallaRegistrarRevisionManual()
        {
            InitializeComponent();
            habilitarPantalla();
            mostrarDatosOrdenados();
        }


        //
        // EVENTOS
        //
        private void TomarSeleccionEvento(object sender, EventArgs e)
        {
            if (listViewEventos.SelectedItems.Count > 0)
            {
                int index = listViewEventos.SelectedItems[0].Index;
                var eventoSeleccionado = eventosOrdenados[index];
                gestor.TomarSelecEventoSismico(eventoSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un evento primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mostrarDatosOrdenados()
        {
            listViewEventos.Items.Clear();
            foreach (var evento in eventosOrdenados)
            {
                var item = new ListViewItem(evento.GetFechaHoraOcurrencia().ToString()); 
                item.SubItems.Add(evento.ObtenerMagnitudSismo().ToString());               
                item.SubItems.Add(evento.GetUbicacionEventoSismico());                              

                listViewEventos.Items.Add(item);
            }
        }

        private void habilitarPantalla()
        {
            gestor = new GestorRevisionManual();
            eventosOrdenados = gestor.OpcRegResultadoObservacion();
        }

        private void PantallaRegistrarRevisionManual_Load(object sender, EventArgs e)
        {

        }
    }

}

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
        }


        //
        // METODOS
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

        public void mostrarDatosOrdenados(List<EventoSismico> eventosOrdenados)
        {
            listViewEventos.Items.Clear();
            this.eventosOrdenados = eventosOrdenados;
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
            gestor = new GestorRevisionManual(this);
            gestor.opcRegistrarResultadoRevision();
        }

        private void PantallaRegistrarRevisionManual_Load(object sender, EventArgs e)
        {

        }

        public void MostrarDatosEvento(string[] datosGenerales, string datosTemporales)
        {
            DetalleDelEvento ventana = new DetalleDelEvento(datosGenerales, datosTemporales);
            ventana.SetGestor(this.gestor);
            ventana.ShowDialog();
        }
    }

}

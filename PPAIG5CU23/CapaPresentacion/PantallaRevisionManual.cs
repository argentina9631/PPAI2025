using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica; // Para acceder a GestorRevisionManual

namespace CapaPresentacion
{
    public partial class PantallaRevisionManual : Form
    {
        private GestorRevisionManual gestor;

        public PantallaRevisionManual()
        {
            InitializeComponent();
            // Instanciamos el gestor de lógica asociado a esta pantalla
            gestor = new GestorRevisionManual();
        }

        // 1 : opcRegResultadoObservacion
        private void btnRegistrarResultado_Click(object sender, EventArgs e)
        {
            // Método llamado cuando el usuario hace clic en "Registrar Resultado de Observación"
            gestor.opcRegResultadoObservacion();
        }

        // 2 : habilitarPantalla
        public void habilitarPantalla()
        {
            // Habilita todos los controles del formulario para permitir interacción
            this.Enabled = true;
        }

        // 12 : mostrarDatosOrdenados
        public void mostrarDatosOrdenados(List<EventoSismico> eventosOrdenados)
        {
            // Limpia la grilla y muestra los eventos sísmicos ordenados por fecha y hora
            dgvEventos.Rows.Clear();
            foreach (var evento in eventosOrdenados)
            {
                dgvEventos.Rows.Add(evento.Id, evento.FechaHora, evento.Ubicacion, evento.Magnitud);
            }
        }

        // 51 : mostrarDatosDelEvento
        public void mostrarDatosDelEvento(EventoSismico evento)
        {
            // Muestra en los controles los datos del evento sísmico seleccionado
            txtFechaHora.Text = evento.FechaHora.ToString();
            txtUbicacion.Text = evento.Ubicacion;
            txtMagnitud.Text = evento.Magnitud.ToString("0.00");
        }

        // 52 : habilitarOpcVisualizarMapa
        public void habilitarOpcVisualizarMapa()
        {
            // Habilita el botón para visualizar el mapa del evento
            btnVisualizarMapa.Enabled = true;
        }

        // 53 : permitirModificacionDatosEvento
        public void permitirModificacionDatosEvento()
        {
            // Permite editar los datos del evento (si fue validado como editable)
            txtUbicacion.Enabled = true;
            txtMagnitud.Enabled = true;
        }

        // 54 : solicitarSeleccionAccion
        public void solicitarSeleccionAccion()
        {
            // Solicita al usuario que seleccione una acción (aceptar/rechazar evento)
            MessageBox.Show("Seleccione si desea aceptar o rechazar el evento.");
        }
    }
}

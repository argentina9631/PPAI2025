//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Logica;
//using Datos;
//System.Windows.Forms.DataVisualization;

namespace Presentacion
{
    public partial class PantallaRevisionManual : Form
    {
        private ListBox lstEventos;
        private ListBox lstSeries;
        private ListBox lstMuestras;
        private ListBox lstDetalles;
        private Label lblAlcance;
        private Label lblClasificacion;
        private Label lblOrigen;
        private Button btnSeleccionarEvento;
        private Button btnVerMuestras;
        private Button btnVerDetalles;
        private Button btnGenerarSismograma;
        private Button btnRechazarEvento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSismograma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GestorRevisionManual gestor;

        public PantallaRevisionManual()
        {
            InitializeComponent();
            gestor = new GestorRevisionManual();
        }

        private void PantallaRevisionManual_Load(object sender, EventArgs e)
        {
            HabilitarPantalla();
            lblAlcance.Visible = false;
            lblClasificacion.Visible = false;
            lblOrigen.Visible = false;
        }

        private void HabilitarPantalla()
        {
            List<EventoSismico> eventos = gestor.BuscarEventoPendienteRevision();

            if (eventos.Count == 0)
            {
                MessageBox.Show("No hay eventos pendientes.");
                return;
            }

            // Asumimos que hay un ListBox llamado lstEventos
            lstEventos.DataSource = eventos;
            lstEventos.DisplayMember = "FechaHoraOcurrencia"; // o cualquier propiedad que quieras mostrar
        }

        private void btnSeleccionarEvento_Click(object sender, EventArgs e)
        {
            EventoSismico eventoSeleccionado = (EventoSismico)lstEventos.SelectedItem;

            gestor.TomarSeleccionEvento(eventoSeleccionado);

            if (gestor.ValidarEstadoBloqueado())
            {
                MessageBox.Show("El evento ya está bloqueado.");
                return;
            }

            if (gestor.ValidarEstadoPendiente())
            {
                gestor.BloquearEvento();
                MostrarDatosEvento();
                lblAlcance.Visible = true;
                lblClasificacion.Visible = true;
                lblOrigen.Visible = true;
            }
        }

        private void MostrarDatosEvento()
        {
            lblAlcance.Text = gestor.ObtenerAlcance();
            lblClasificacion.Text = gestor.ObtenerClasificacion();
            lblOrigen.Text = gestor.ObtenerOrigen();

            List<SerieTemporal> series = gestor.ObtenerSeriesTemporales();
            lstSeries.DataSource = series;
            lstSeries.DisplayMember = "Id"; // o como quieras mostrar
        }

        private void btnVerMuestras_Click(object sender, EventArgs e)
        {
            SerieTemporal serie = (SerieTemporal)lstSeries.SelectedItem;

            if (serie == null)
            {
                MessageBox.Show("seleccioná una serie temporal por favor");
                return;
            }

            List<MuestraSismica> muestras = gestor.ObtenerMuestras(serie);
            lstMuestras.DataSource = muestras;
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            MuestraSismica muestra = (MuestraSismica)lstMuestras.SelectedItem;

            if (muestra == null)
            {
                MessageBox.Show("seleccioná una muestra por favor");
                return;
            }

            List<DetalleMuestraSismica> detalles = gestor.ObtenerDetalles(muestra);
            lstDetalles.DataSource = detalles;
        }

        private void btnGenerarSismograma_Click(object sender, EventArgs e)
        {
            SerieTemporal serie = (SerieTemporal)lstSeries.SelectedItem;

            if (serie == null)
            {
                MessageBox.Show("seleccioná un detalle por favor");
                return;
            }

            InicializarGrafico();

            var datos = GeneradorSismograma.Generar(serie);

            foreach (var punto in datos)
            {
                chartSismograma.Series["Velocidad"].Points.AddXY(punto.Item1, punto.Item2);
            }

            MessageBox.Show("Sismograma generado con éxito.");
        }

        private void InicializarGrafico()
        {
            chartSismograma.Series.Clear();
            chartSismograma.ChartAreas.Clear();

            var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea("Area1");
            chartSismograma.ChartAreas.Add(area);

            var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Velocidad");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartSismograma.Series.Add(serie);
        }

        private void btnRechazarEvento_Click(object sender, EventArgs e)
        {
            if (lstEventos.SelectedItem == null)
            {
                MessageBox.Show("seleccioná un evento antes de intentar rechazarlo por favor");
                return;
            }

            EventoSismico eventoSeleccionado = (EventoSismico)lstEventos.SelectedItem;
            gestor.TomarSeleccionEvento(eventoSeleccionado);

            if (gestor.ValidarRechazo())
            {
                MessageBox.Show("El evento ya fue rechazado.");
            }
            else
            {
                MessageBox.Show("Acción: Rechazar evento registrada.");
                // Aquí podrías cambiar su estado a Rechazado si lo implementás
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRevisionManual));
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.lstSeries = new System.Windows.Forms.ListBox();
            this.lstMuestras = new System.Windows.Forms.ListBox();
            this.lstDetalles = new System.Windows.Forms.ListBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnSeleccionarEvento = new System.Windows.Forms.Button();
            this.btnVerMuestras = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnGenerarSismograma = new System.Windows.Forms.Button();
            this.btnRechazarEvento = new System.Windows.Forms.Button();
            this.chartSismograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSismograma)).BeginInit();
            this.SuspendLayout();
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.Location = new System.Drawing.Point(16, 33);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(494, 95);
            this.lstEventos.TabIndex = 0;
            // 
            // lstSeries
            // 
            this.lstSeries.FormattingEnabled = true;
            this.lstSeries.Location = new System.Drawing.Point(17, 233);
            this.lstSeries.Name = "lstSeries";
            this.lstSeries.Size = new System.Drawing.Size(494, 95);
            this.lstSeries.TabIndex = 1;
            // 
            // lstMuestras
            // 
            this.lstMuestras.FormattingEnabled = true;
            this.lstMuestras.Location = new System.Drawing.Point(16, 369);
            this.lstMuestras.Name = "lstMuestras";
            this.lstMuestras.Size = new System.Drawing.Size(494, 95);
            this.lstMuestras.TabIndex = 2;
            // 
            // lstDetalles
            // 
            this.lstDetalles.FormattingEnabled = true;
            this.lstDetalles.Location = new System.Drawing.Point(17, 502);
            this.lstDetalles.Name = "lstDetalles";
            this.lstDetalles.Size = new System.Drawing.Size(494, 95);
            this.lstDetalles.TabIndex = 3;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.BackColor = System.Drawing.Color.Transparent;
            this.lblAlcance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblAlcance.Location = new System.Drawing.Point(468, 130);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(101, 29);
            this.lblAlcance.TabIndex = 4;
            this.lblAlcance.Text = "alcance";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblClasificacion.Location = new System.Drawing.Point(521, 159);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(152, 29);
            this.lblClasificacion.TabIndex = 5;
            this.lblClasificacion.Text = "clasificacion";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblOrigen.Location = new System.Drawing.Point(452, 188);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(83, 29);
            this.lblOrigen.TabIndex = 6;
            this.lblOrigen.Text = "origen";
            // 
            // btnSeleccionarEvento
            // 
            this.btnSeleccionarEvento.Location = new System.Drawing.Point(536, 33);
            this.btnSeleccionarEvento.Name = "btnSeleccionarEvento";
            this.btnSeleccionarEvento.Size = new System.Drawing.Size(85, 95);
            this.btnSeleccionarEvento.TabIndex = 7;
            this.btnSeleccionarEvento.Text = "Seleccionar Evento";
            this.btnSeleccionarEvento.UseVisualStyleBackColor = true;
            this.btnSeleccionarEvento.Click += new System.EventHandler(this.btnSeleccionarEvento_Click);
            // 
            // btnVerMuestras
            // 
            this.btnVerMuestras.Location = new System.Drawing.Point(536, 233);
            this.btnVerMuestras.Name = "btnVerMuestras";
            this.btnVerMuestras.Size = new System.Drawing.Size(85, 95);
            this.btnVerMuestras.TabIndex = 8;
            this.btnVerMuestras.Text = "Ver Muestras";
            this.btnVerMuestras.UseVisualStyleBackColor = true;
            this.btnVerMuestras.Click += new System.EventHandler(this.btnVerMuestras_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(536, 369);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(85, 95);
            this.btnVerDetalles.TabIndex = 9;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnGenerarSismograma
            // 
            this.btnGenerarSismograma.Location = new System.Drawing.Point(536, 502);
            this.btnGenerarSismograma.Name = "btnGenerarSismograma";
            this.btnGenerarSismograma.Size = new System.Drawing.Size(85, 47);
            this.btnGenerarSismograma.TabIndex = 10;
            this.btnGenerarSismograma.Text = "Generar Sismograma";
            this.btnGenerarSismograma.UseVisualStyleBackColor = true;
            this.btnGenerarSismograma.Click += new System.EventHandler(this.btnGenerarSismograma_Click);
            // 
            // btnRechazarEvento
            // 
            this.btnRechazarEvento.Location = new System.Drawing.Point(536, 555);
            this.btnRechazarEvento.Name = "btnRechazarEvento";
            this.btnRechazarEvento.Size = new System.Drawing.Size(85, 42);
            this.btnRechazarEvento.TabIndex = 11;
            this.btnRechazarEvento.Text = "Rechazar Evento";
            this.btnRechazarEvento.UseVisualStyleBackColor = true;
            this.btnRechazarEvento.Click += new System.EventHandler(this.btnRechazarEvento_Click);
            // 
            // chartSismograma
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSismograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSismograma.Legends.Add(legend1);
            this.chartSismograma.Location = new System.Drawing.Point(646, 33);
            this.chartSismograma.Name = "chartSismograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSismograma.Series.Add(series1);
            this.chartSismograma.Size = new System.Drawing.Size(704, 564);
            this.chartSismograma.TabIndex = 12;
            this.chartSismograma.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clasificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alcance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(886, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tiempo en segundos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1218, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Velocidad en m/s";
            // 
            // PantallaRevisionManual
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartSismograma);
            this.Controls.Add(this.btnRechazarEvento);
            this.Controls.Add(this.btnGenerarSismograma);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnVerMuestras);
            this.Controls.Add(this.btnSeleccionarEvento);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.lstDetalles);
            this.Controls.Add(this.lstMuestras);
            this.Controls.Add(this.lstSeries);
            this.Controls.Add(this.lstEventos);
            this.Name = "PantallaRevisionManual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaRevisionManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSismograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}


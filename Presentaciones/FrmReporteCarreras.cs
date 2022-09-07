using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidad.AccesoDatos;

namespace Universidad.Presentaciones
{
    public partial class FrmReporteCarreras : Form
    {
        DBHelper oDatos = new DBHelper();
        public FrmReporteCarreras()
        {
            InitializeComponent();
        }

        private void FrmReporteCarreras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCarreras.carreras' Puede moverla o quitarla según sea necesario.
            //this.carrerasTableAdapter.Fill(this.dsCarreras.carreras);
            //this.carrerasBindingSource
            

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_CARRERA");
            this.carrerasBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }

        private void btnmostrarfiltro_Click(object sender, EventArgs e)
        {
            DataTable tabla = oDatos.Filtro(txtfiltro.Text);
            this.carrerasBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}

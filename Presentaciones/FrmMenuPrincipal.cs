using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidad.Presentaciones
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmplan nuevacarrera = new Frmplan();
            nuevacarrera.ShowDialog();
        }

        private void editarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditar editarcarrera = new FrmEditar();
            editarcarrera.ShowDialog();
        }

        private void nuevoReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCarreras reportecarrera = new FrmReporteCarreras();
            reportecarrera.ShowDialog();
        }
    }
}

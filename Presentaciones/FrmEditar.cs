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
using Universidad.Dominio;

namespace Universidad.Presentaciones
{
    public partial class FrmEditar : Form
    {
        DBHelper oDatos = new DBHelper();
        public FrmEditar()
        {
            InitializeComponent();
            cargargrilla();
            CargarAsignaturas();
            CargarCarrera();
            inicializarcampos();
           
        }
        public void inicializarcampos()
        {
            txtnombre.Enabled = false;
            txtaño.Enabled = false;
            cboasignatura.Enabled = false;
            rbtprimercuatrimestre.Enabled = false;
            rbtsegundocuatrimestre.Enabled = false;

        }
        public void CargarCarrera()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_CARRERA");
            cbocarrera.DataSource = tabla;
            cbocarrera.ValueMember = tabla.Columns[0].ColumnName;
            cbocarrera.DisplayMember = tabla.Columns[1].ColumnName;
        }
        public void CargarAsignaturas()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_ASIGNATURAS");
            cboasignatura.DataSource = tabla;
            cboasignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboasignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        public void cargargrilla()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_DETALLE");
            dgvdetalle.DataSource = tabla;

        }

        private void cargarCampos(int posicion)
        {
            
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_DETALLES_CARRERA");
            
            
            
            cboasignatura.SelectedValue = (int)tabla.Rows[posicion][2];
            txtaño.Text = Convert.ToString(tabla.Rows[posicion][3]);
            if (Convert.ToInt32(tabla.Rows[posicion][4]) == 1)
                rbtprimercuatrimestre.Checked = true;
            else
                rbtsegundocuatrimestre.Checked = true;
            
            
             
        }

    

        private void dgvdetalle_SelectionChanged(object sender, EventArgs e)
        {
            this.cargarCampos(dgvdetalle.CurrentRow.Index);
        }

        private void cbocarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cbocarrera.SelectedItem;
            txtnombre.Text = (string)item.Row.ItemArray[1];
        }

        private void btngrabarcarrera_Click(object sender, EventArgs e)
        {
            oDatos.updateCarrera((int)cbocarrera.SelectedValue, txtnombre.Text);
            CargarCarrera();
            DataRowView item = (DataRowView)cbocarrera.SelectedItem;
            txtnombre.Text = (string)item.Row.ItemArray[1];
            cargargrilla();
        }

        private void btngrabardetalle_Click(object sender, EventArgs e)
        {
            int posicion = (int)dgvdetalle.CurrentRow.Index;
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_DETALLES_CARRERA");
            int id_detalle = (int)tabla.Rows[posicion][0];
            int carrera = (int)tabla.Rows[posicion][1];
            int asignatura = (int)cboasignatura.SelectedValue;
            int anio = Convert.ToInt32(txtaño.Text);
            int cuatrimestre;
            if (rbtprimercuatrimestre.Checked == true)
                cuatrimestre = 1;
            else
                cuatrimestre = 2;
            oDatos.elminardetalle(id_detalle);
            oDatos.insertardetalle(anio, cuatrimestre, asignatura, carrera);
            cargargrilla();
        }

        private void btneditarcarrera_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
        }

        private void btncancelarcarrera_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            DataRowView item = (DataRowView)cbocarrera.SelectedItem;
            txtnombre.Text = (string)item.Row.ItemArray[1];
        }

        private void btncancelardetalle_Click(object sender, EventArgs e)
        {
            txtaño.Enabled = false;
            cboasignatura.Enabled = false;
            rbtprimercuatrimestre.Enabled = false;
            rbtsegundocuatrimestre.Enabled = false;
            this.cargarCampos(dgvdetalle.CurrentRow.Index);

        }

        private void btneditardetalle_Click(object sender, EventArgs e)
        {
            txtaño.Enabled = true;
            cboasignatura.Enabled = true;
            rbtprimercuatrimestre.Enabled = true;
            rbtsegundocuatrimestre.Enabled = true;
        }
    }

  
}

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


namespace Universidad
{
    public partial class Frmplan : Form
    {
        
        Carrera carrera = new Carrera();
        

        DBHelper oDatos = new DBHelper();

        public Frmplan()
        {
            InitializeComponent();
        }

        private void Frmplan_Load(object sender, EventArgs e)
        {
            CargarAsignaturas();
            
        }



        public void CargarAsignaturas()
        {
            DataTable tabla = oDatos.ConsultarDB("SP_CONSULTAR_ASIGNATURAS");
            cboasignatura.DataSource = tabla;
            cboasignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboasignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }
      


        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboasignatura.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("seleccione una materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtanio.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbnprimer.Checked && !rbnsegundo.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DetalleCarrera dc in carrera.DetallesCarrera)
            {
                if (dc.Materia.nombre == cboasignatura.Text)
                {
                    MessageBox.Show("Solo puede agregar una vez cada materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            int id = Convert.ToInt32(cboasignatura.SelectedValue);
            string nombre = cboasignatura.Text;
            Asignatura asignatura = new Asignatura(nombre,id);
            int aniocursado = Convert.ToInt32(txtanio.Text);
            int cuatrimestre = 0;
            if (rbnprimer.Checked) cuatrimestre = 1;
            if (rbnsegundo.Checked) cuatrimestre = 2;
            DetalleCarrera dt = new DetalleCarrera(aniocursado, cuatrimestre, asignatura);
            carrera.Nombre = txtcarrera.Text;
            carrera.AgregarDetalle(dt);
            dgvDetalle.Rows.Add(new object[] { id,nombre,aniocursado,cuatrimestre  });


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtcarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera",
                "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            int id_carrera = oDatos.AltaCarrera("SP_INSERTAR_MAESTRO", carrera);
            oDatos.AltaDetallesCarrera_SP("SP_INSERTAR_DETALLE", id_carrera, carrera);



            
            MessageBox.Show("Detalle Cargado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

           

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                if(dgvDetalle.CurrentRow.IsNewRow)
                {
                    return;
                }
                else
                {
                    carrera.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                    dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                }
               
            }
        }
    }
}
                                                                                                                    
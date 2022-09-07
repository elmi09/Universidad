using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Universidad.Dominio;

namespace Universidad.AccesoDatos
{
    internal class DBHelper
    {
        const string conexion = @"Data Source=DESKTOP-EN5VFFB\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(conexion);
        SqlCommand cmd = new SqlCommand();
        SqlTransaction trs = null;
        int id_carrera;
        public void insertardetalle(int anio,int cuatrimestre,int asignatura,int carrera)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERTAR_DETALLE";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@anio", anio);
            cmd.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
            cmd.Parameters.AddWithValue("@asignatura", asignatura);
            cmd.Parameters.AddWithValue("@carrera", carrera);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public void elminardetalle(int posicion)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ELIMINAR_DETALLE_CARRERA";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_detalle", posicion);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable Filtro(string palabra)
        {
           
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_BUSCARCARRERA";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@palabra", palabra);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public void updateCarrera(int posicion,string nombre)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_EDITAR_CARRERA";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_carrera", posicion);
            cmd.Parameters.AddWithValue("@nombre_carrera", nombre);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }


        public DataTable ConsultarDB(string sp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Parameters.Clear();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();



            return tabla;
        }
        public void AltaDetallesCarrera_SP(string SPNombre, int id_carrera, Carrera carrera)
        {
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPNombre;

                for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Transaction = trs;
                    cmd.Parameters.AddWithValue("@anio", carrera.DetallesCarrera[i].AnioCursado);
                    cmd.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                    cmd.Parameters.AddWithValue("@asignatura", carrera.DetallesCarrera[i].Materia.id);
                    cmd.Parameters.AddWithValue("@carrera", id_carrera);

                    cmd.ExecuteNonQuery();
                }

                cnn.Close();
                
            }
            catch (Exception)
            {
                if (trs != null) trs.Rollback();
            }
            finally
            {
                if(cnn.State==ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            trs.Commit();

        }

        public  int  AltaCarrera(string spname,Carrera carrera)
        {
            
            
            try
            {
                
                cnn.Open();
                trs = cnn.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spname;
                cmd.Parameters.AddWithValue("@nombre", carrera.Nombre);
                SqlParameter param = new SqlParameter("new_id", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                id_carrera = Convert.ToInt32(param.Value);
                trs.Commit();
                cnn.Close();
                
                
            }

            catch (Exception)
            {
                if (trs != null) trs.Rollback();

            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            
            return id_carrera;



        }



 
    }
}

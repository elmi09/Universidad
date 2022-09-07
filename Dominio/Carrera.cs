using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Universidad.Dominio {  

internal class Carrera
{
    public string Nombre { get; set; }
    List<DetalleCarrera> detalles = new List<DetalleCarrera>();

        
    const string conexion = @"Data Source=DESKTOP-NE91IT5\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
    SqlConnection cnn = new SqlConnection(conexion);
    public List<DetalleCarrera> DetallesCarrera
        {
            set { detalles = value; }
            get { return detalles; }
        }


    public void AgregarDetalle (DetalleCarrera detalle)
    {
        detalles.Add(detalle);
    }
    public void QuitarDetalle (int posicion)
    {

            detalles.RemoveAt(posicion);

    }



}
}
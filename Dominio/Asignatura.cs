using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio
{
    internal class Asignatura
    {
 

        public string nombre { get; set; }
        public int id { get; set; }
        public Asignatura(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }




    }
}

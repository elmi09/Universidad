using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Dominio
{
    internal class DetalleCarrera
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Materia { get; set; }


        public DetalleCarrera(int anioCursado, int cuatrimestre, Asignatura materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }




    }
}

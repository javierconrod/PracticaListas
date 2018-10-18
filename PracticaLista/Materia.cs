using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLista
{
    class Materia
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public int CalificacionPrimerParcial { get; set; }
        public int CalificacionSegundoParcial { get; set; }
        public int CalificacionTercerParcial { get; set; }
        public int CalificacionFinal { get; set; }

        

        public Materia(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;

            CalificacionFinal = 0;
            CalificacionPrimerParcial = 0;
            CalificacionSegundoParcial = 0;
            CalificacionTercerParcial = 0;
        }
        public Materia(string clave, string nombre, int cal1, int cal2, int cal3, int calf)
        {
            Clave = clave;
            Nombre = nombre;

            CalificacionFinal = calf;
            CalificacionPrimerParcial = cal1;
            CalificacionSegundoParcial = cal2;
            CalificacionTercerParcial = cal3;
        }
    }
}

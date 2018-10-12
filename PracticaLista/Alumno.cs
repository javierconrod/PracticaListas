using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLista
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }

        public Alumno()
        {
            Nombre = "";
            Matricula = "";
            Carrera = "";
        }
        public Alumno(string nombre, string matricula, string carrera)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
        }
    }
}

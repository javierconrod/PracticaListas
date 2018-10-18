using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Alumno> alumnos = new List<Alumno>();

        public MainWindow()
        {
            InitializeComponent();

            Materia historia = new Materia("HST123", "Historia");
            Materia matematicas = new Materia("MAT142", "Matematicas");
            Materia ciencias = new Materia("CNS165", "Ciencias Naturales");
            Materia ingles = new Materia("ING001", "Inglés");
            Materia fisica = new Materia("FIS453", "Física");

            alumnos.Add(new Alumno("Juan Perez", "153697", "Lic. en Derecho"));
            alumnos.Add(new Alumno("Pedro Martínez", "164985", "Ing. Civil"));
            alumnos.Add(new Alumno("María López", "135497", "Ing. en Minas"));
            alumnos.Add(new Alumno("Ana Chávez", "134679", "Lic. en Psicología"));

            alumnos[0].Materias.Add(historia);
            alumnos[0].Materias.Add(ciencias);

            alumnos[1].Materias.Add(ingles);
            alumnos[1].Materias.Add(historia);

            alumnos[2].Materias.Add(matematicas);
            alumnos[2].Materias.Add(fisica);

            alumnos[3].Materias.Add(ciencias);
            alumnos[3].Materias.Add(ingles);

            foreach (Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem()
                {
                    Content = alumno.Nombre
                }
                );
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
            lstMaterias.Items.Clear();

            foreach (Materia materia in alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(new ListBoxItem()
                {
                    Content = materia.Nombre
                });
            }
        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstMaterias.SelectedIndex != -1)
            {
                lblNombreMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
                lblClave.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
            }

        }
    }
}

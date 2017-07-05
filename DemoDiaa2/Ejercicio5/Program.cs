using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Universidad escuela = new Universidad();

            escuela.IngresarAlumno("Noelia Simpson");
            escuela.IngresarProfesor("Micaela Paez");
            escuela.IngresarAlumno("Finca Torres");
            escuela.IngresarProfesor("Dadiva Esmero");

            Console.WriteLine("Cantidad de alumnos: "+escuela.GetAlumnos());
            Console.WriteLine("Cantidad de profesores: " + escuela.GetProfesores());

            escuela.MostrarAlumnos();
            escuela.MostrarProfes();

            Console.ReadKey();

        }
    }
}

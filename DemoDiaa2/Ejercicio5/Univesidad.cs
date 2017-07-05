using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Universidad
    {
        private static int cantAlumnos;
        public int cantMaterias;
        public static int cantProfesores;
        public List<string> Alumnos=new List<string>();
        public List<string> Profesores = new List<string>();

        public Universidad()
        {
            cantAlumnos = 0;
            this.cantMaterias = 0;
            cantProfesores = 0;
           
       

        }

        public void IngresarAlumno(string nombre)
        {   
           
            this.Alumnos.Add(nombre);
            cantAlumnos++;
           
        }

        public void IngresarProfesor(string nombre)
        {   
            cantProfesores++;
            this.Profesores.Add(nombre);
            
        }

        public int GetAlumnos()
        {
            return cantAlumnos;

        }

        public int GetProfesores()
        {
            return cantProfesores;
        }

        public void MostrarAlumnos()
        {
            foreach (string nombre in Alumnos)
            {
                Console.WriteLine(nombre);
            }
        }

        public void MostrarProfes()
        {
            foreach (string nombre in Profesores)
            {
                Console.WriteLine(nombre);
            }
        }

    }
}

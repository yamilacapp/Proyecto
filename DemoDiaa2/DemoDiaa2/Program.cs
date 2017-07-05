using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaAlumnos=new List<string>();
            List<int> listaEdades = new List<int> { 25, 67, 48, 36, 15 };

            listaAlumnos.Add("Diego Milito");
            listaAlumnos.Add("Luli Aued");
            listaAlumnos.Add("Ezequiel Videla");
            listaAlumnos.Add("Agustin Orion");


            foreach (string nombre in listaAlumnos)
            {
                Console.WriteLine(nombre);
            }

            listaEdades.Sort();
            listaEdades.Reverse();

            foreach (int edad in listaEdades)
            {
                Console.WriteLine(edad);
            }

            if(listaAlumnos.Contains("Agustin Orion"))
            {
                Console.WriteLine(listaAlumnos.IndexOf("Agustin Orion"));
                listaAlumnos.RemoveAt(listaAlumnos.IndexOf("Agustin Orion"));

            }

            foreach (string item in listaAlumnos)
            {
                Console.WriteLine(item);
            }

            listaAlumnos.Insert(2, "Julian Weich");
            if (listaAlumnos.Contains("Julian Weich"))
            {
                Console.WriteLine("Contiene el elemento!");
            }

            foreach (string nombre in listaAlumnos)
            {
                Console.WriteLine(nombre);
            }

           

		 
	
    Console.ReadKey();
        }
    }
}

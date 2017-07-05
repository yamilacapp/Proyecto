using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Bienvenido {0}, su edad ingresada es {1}", nombre, edad);


            Console.ReadKey();

        }
    }
}

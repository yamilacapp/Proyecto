using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Alejandro", "Magallanes", "Viajes del Caribe", "Estrada", "Argentina", 546);

            libro1.MostrarDatos();

            Console.ReadKey();

        }
    }
}

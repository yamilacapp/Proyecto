using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumero = { 1, 3, 5, 7, 9 };
            int aux = 0;
            float promedio = 0;

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                aux = aux + arrayNumero[i];
            }
            promedio = aux / arrayNumero.Length;

            Console.WriteLine("Promedio: " + promedio);

                Console.ReadKey();
        }
    }
}

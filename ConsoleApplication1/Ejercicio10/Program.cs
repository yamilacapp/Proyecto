using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumero = new int[10];
            int numValor = 0;

            Console.WriteLine("Ingrese un numero: ");
            numValor = int.Parse(Console.ReadLine());
            arrayNumero[0] = numValor;

            for (int i = 1; i < arrayNumero.Length; i++)
            {
                numValor++;
                arrayNumero[i] = numValor;
            }

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                Console.Write(arrayNumero[i]);

            }

            Console.ReadKey();

        }
    }
}

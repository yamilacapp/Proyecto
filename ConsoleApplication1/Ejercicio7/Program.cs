using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumero = { 3, 2, 7, 5, 1 };
            const int TAMAÑO=5;
            int aux;

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                for (int j = i + 1; j < arrayNumero.Length; j++)
                {
                    if (arrayNumero[j] < arrayNumero[i])
                    {
                        aux = arrayNumero[i];
                        arrayNumero[i] = arrayNumero[j];
                        arrayNumero[j] = aux;
                    }
                    
                }
            }

          

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                Console.Write(arrayNumero[i]);

            }

            Console.ReadKey();


        }
    }
}

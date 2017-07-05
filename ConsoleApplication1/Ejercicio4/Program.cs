using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNombres = new string[4];
            arrayNombres[0] = "Hola";
            arrayNombres[1] = "Buenos";
            arrayNombres[2] = "Dias";
            arrayNombres[3] = "Compañero";

            for (int i = 0; i < arrayNombres.Length; i++)
            {
                Console.WriteLine(arrayNombres[i]);
            }

            int[] arrayNumero = { 23, 24, 25, 24 };

            for (int j = 0; j < arrayNumero.Length; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(arrayNumero[j]);
                }
            }


                Console.ReadKey();
        }
    }
}

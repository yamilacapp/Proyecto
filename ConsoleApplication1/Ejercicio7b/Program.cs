using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElement = { 1, 2, 3, 4, 5 };
            int aux = 5;
            int valorFinal = 0;

            for (int i = 0; i < arrayElement.Length; i++)
            {
                if (arrayElement[i] == aux)
                {
                    valorFinal= i;
                    break;
                   // Console.WriteLine("Posicion encontrada: " + i);
                }
                else
                {

                    valorFinal= -1;
                   // Console.WriteLine("Posicion encontrada: -1");

                }
            }

            if(valorFinal!=-1)
            {
                Console.WriteLine("Posicion encontrada: "+ valorFinal);
            }
            else {
                Console.WriteLine("Posicion encontrada: -1");
            }

            Console.ReadKey();

        }
    }
}

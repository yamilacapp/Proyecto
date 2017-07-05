using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("Los numero ingresados son: {0}, {1}", numero1, numero2);
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("Los numero ingresados son {0}, {1}", numero2, numero1);
            }
            else
            {
                Console.WriteLine("¡Los numeros ingresados son iguales!");

            }


            Console.ReadKey();
        }
    }
}

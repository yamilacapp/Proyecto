using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero entre 0 y 9");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 0: Console.WriteLine("Ingreso Cero");
                    break;
                case 1: Console.WriteLine("Ingreso Uno");
                    break;
                case 2:Console.WriteLine("Ingreso Dos");
                    break;
                case 3:Console.WriteLine("Ingreso Tres");
         
                    break;
                case 4:Console.WriteLine("Ingreso Cuatro");
                    break;
                case 5:Console.WriteLine("Ingreso Cinco");
                    break;
                case 6:Console.WriteLine("Ingreso Seis");
                    break;
                case 7:Console.WriteLine("Ingreso Siete");
                    break;
                case 8:Console.WriteLine("Ingreso Ocho");
                    break;
                case 9:Console.WriteLine("Ingreso Nueve");
                    break;
                default:Console.WriteLine("Ingreso un numero incorrecto");
                    break;
            }


            Console.ReadKey();
        }
    }
}

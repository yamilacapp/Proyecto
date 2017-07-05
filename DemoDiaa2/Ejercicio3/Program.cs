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

            float a = 2;
            float b=4;
            float c=1;
            float d=3;

            Calculadora Calcu = new Calculadora();

           Console.WriteLine("Resultado 1: "+Calcu.Sumar(3, 4));
           Console.WriteLine("Resultado 2: "+Calcu.Sumar(3, 4, 5));
           Console.WriteLine("Resultado 3: "+Calcu.Sumar(a, b));
           Console.WriteLine("Resultado 4: "+Calcu.Sumar(a, b, c, d));

            Console.ReadKey();
        }
    }
}

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

            int valor;
            int resultado = 0;

            Console.WriteLine("Ingrese un valor del 0 al 9: ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 1 && valor <= 3)
            {
                
                   resultado = valor * 10;
    
            }
            if (valor >= 4 && valor < 7)
            {
                resultado = valor * 100;
            }

            else if (valor >= 7 && valor <= 9)
            {
                resultado = valor * 1000;
            }
            else
            {
                if (valor > 9 || valor == 0)
                {
                    Console.WriteLine("Error valo ingresado incorrecto");
                }


            }

            Console.WriteLine("Resultado es:" + resultado);

            Console.ReadLine();
        }
    }
}

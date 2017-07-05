using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double tazaAnual = 0;
            double capitalInicial = 0;
            double cantAños = 0;
            double interesGanado = 0;

            Console.WriteLine("Ingrese capital inicial: ");
            capitalInicial = double.Parse(Console.ReadLine());
            while (capitalInicial < 0)
            {
                Console.WriteLine("El valor ingresado es incorrecto. Reingrese: ");
                capitalInicial = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese taza de interes: ");
            tazaAnual = double.Parse(Console.ReadLine());
            while(tazaAnual<0 || tazaAnual>50)
            {
             Console.WriteLine("El valor ingresado es incorrecto. Reingrese:"); 
                tazaAnual=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese cantidad de años: ");
            cantAños = double.Parse(Console.ReadLine());
            while(cantAños<0)
            {
                Console.WriteLine("El valor ingresado es incorrecto. Reingrese");
                cantAños=double.Parse(Console.ReadLine());

            }


            for (int i = 0; i < cantAños; i++)
            {
                interesGanado = capitalInicial * tazaAnual / 100;
                capitalInicial = capitalInicial + interesGanado;
                Console.WriteLine("El interes ganado durante el año {0} es ${1}", i+1, interesGanado);
            }

            Console.WriteLine("El capital acumulado es $"+capitalInicial);
            Console.ReadKey();
        }
    }
}

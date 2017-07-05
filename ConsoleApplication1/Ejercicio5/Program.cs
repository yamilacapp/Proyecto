using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1=3;
            int exponente=3;
            int resultado = base1;
            int i=0;
            int j=0;

            while (i < exponente-1)
            {
                resultado = resultado*base1;
                i++;
            }

            Console.WriteLine("La potencia es: {0}", resultado);

            resultado = base1;

            for (j = 0; j < exponente-1; j++)
            {
                resultado = resultado*base1;
            }

            Console.WriteLine("La potencia es: {0}", resultado);    
            
            
            Console.ReadKey();
        }
    }
}

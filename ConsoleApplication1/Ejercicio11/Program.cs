using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayFrase = "";
            Console.WriteLine("Ingrese una frase: ");
            arrayFrase = Console.ReadLine();
            int band = 0;
            int i=0;

           // for{
                
                for(int j = arrayFrase.Length-1; j >= 0; j--)
                {
                  
                    if (arrayFrase[j] == arrayFrase[i])
                    {
                        band = 1;
                        Console.WriteLine("igual");
                        i++;
                        
                        
                    }
                   /* if (i == arrayFrase.Length - 1)
                    {
                        break;
                    }
                    */

                    else
                    {
                        band = -1;
                        Console.WriteLine("no igual");
                        break;
                    }
                    if (band == -1)
                    {
                        break;
                    }

                }
                

           // }while(i<arrayFrase.Length);

            if (band == 1)
            {
                Console.WriteLine("La frase es un palindromo..");
            }
            else
            {
                Console.WriteLine("La frase no es un palindromo..");
            }


            Console.ReadKey();
        }
    }
}

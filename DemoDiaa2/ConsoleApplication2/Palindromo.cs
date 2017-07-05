using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Palindromo
    { private int band;
    public string cadena;

       
        public bool ValidarPalindomo()
        {   int i=0;
       
            for (int j = this.cadena.Length - 1; j >= 0; j--)
            {

                if (this.cadena[j] == this.cadena[i])
                {
                    this.band = 1;
                    //Console.WriteLine("igual");
                    i++;


                }
                /* if (i == arrayFrase.Length - 1)
                 {
                     break;
                 }
                 */

                else
                {
                    this.band = -1;
                    // Console.WriteLine("no igual");
                    break;
                }
                if (this.band == -1)
                {
                    break;
                }

            }


            // }while(i<arrayFrase.Length);

            if (this.band == 1)
            {
                //Console.WriteLine("La frase es un palindromo..");
                return true;
            }
            else
            {
                // Console.WriteLine("La frase no es un palindromo..");
                return false;
            }
        }
    }
}

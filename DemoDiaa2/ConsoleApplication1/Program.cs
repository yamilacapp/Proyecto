using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() { 23, 11, 45, 34, 79, 67 };

            listaNumeros.Sort();

            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}

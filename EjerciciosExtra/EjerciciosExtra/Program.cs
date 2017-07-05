using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2002, 04, 30);

            Console.WriteLine("Fecha: "+ fecha.ToString("dd/MM/yyyy"));
 
            Random numero = new Random();

           Console.WriteLine("Numero Random: "+numero.Next(99, 2001));

         Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAdicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafetera NewCafe = new Cafetera(1000, 5000);

            Console.WriteLine("Cantidad Actual: " + NewCafe.GetCantAct());
            Console.WriteLine("Cantidad Max: " + NewCafe.GetCantMax());

            NewCafe.ServirCafe(20);
            Console.WriteLine("Cantidad Actual luego de servir: " + NewCafe.GetCantAct());
            Console.WriteLine("Cantidad Max luego de servir: " + NewCafe.GetCantMax());

            NewCafe.VaciarCafetera();
            Console.WriteLine("Cantidad Actual luego de vaciar: " + NewCafe.GetCantAct());
            Console.WriteLine("Cantidad Max luego de vaciar: " + NewCafe.GetCantMax());

            NewCafe.LlenarCafetera();
            Console.WriteLine("Cantidad Actual luego de llenar: " + NewCafe.GetCantAct());
            Console.WriteLine("Cantidad Max luego de llenar: " + NewCafe.GetCantMax());

            NewCafe.AgregarCafe(50);

            Random rnd = new Random();
            int num = rnd.Next(100, 200);
            Console.WriteLine("Numero random: " + num);
            //Console.WriteLine("Numero random: "+rnd.Next(1000, 2000));



            Console.ReadKey();
        }
    }
}

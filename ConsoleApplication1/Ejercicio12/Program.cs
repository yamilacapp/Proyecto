using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
           // Console.WriteLine("Ingrese un valor de temperatura entre 0 y 100");
            //temp = double.Parse(Console.ReadLine());
            double ntemp = 0;
            char usuario='s';

            string grados = "";
           // Console.WriteLine("Ingrese en que escala quiere expresarlo: ");
            //grados = Console.ReadLine();

            while (usuario == 's')
            {
                Console.WriteLine("Ingrese un valor de temperatura entre 0 y 100");
                temp = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese en que escala quiere expresarlo: ");
                grados = Console.ReadLine();
                switch (grados)
                {


                    case "Celsius": Console.WriteLine("La temperatura ingresada es {0} grados Celsius", temp);
                        break;
                    case "Fahren":
                        ntemp = (1.8 * temp + 32);
                        Console.WriteLine("La temperatura en grados Fharenheit es " + ntemp);
                        break;
                    case "Kelvin":
                        ntemp = temp + 273.15;
                        Console.WriteLine("La temperatura ingresada en grados Kelvin es: " + ntemp);
                        break;
                    default: Console.WriteLine("No ingreso un valor valido");
                        break;


                }

                double dist = 0;
                string nvalor = "";
                Console.WriteLine("Ingrese un valor de distancia: ");
                dist = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese en que valor quiere expresarlo: ");
                nvalor = Console.ReadLine();
                double valorFinal = 0;

                switch (nvalor)
                {
                    case "Metros": Console.WriteLine("La distancia en metros es: " + dist);
                        break;
                    case "Pies": valorFinal = (3.28083 * dist);
                        Console.WriteLine("La distancia expresada en Pies es: " + valorFinal);
                        break;
                    case "Centimetros": valorFinal = 100 * dist;
                        Console.WriteLine("La distancia expresada en Centimetros es: " + valorFinal);
                        break;
                    case "Kilometros": valorFinal = 0.001 * dist;
                        Console.WriteLine("La distancia expresada en Kilometros es: " + valorFinal);
                        break;
                    case "Millas": valorFinal = (0.001 * dist) * 0.62137;
                        Console.WriteLine("La distancia expresada en Millas es: " + valorFinal);
                        break;
                    case "Pulgadas": valorFinal = 39.37 * dist;
                        Console.WriteLine("La distancia expresada en Pulgadas es: " + valorFinal);
                        break;



                }

                Console.WriteLine("Desea continuar? s/n");
                usuario = char.Parse(Console.ReadLine());
                Console.Clear();

            }


            Console.ReadLine();

        }
    }
}

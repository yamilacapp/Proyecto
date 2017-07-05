using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa1
{
    class Program
    {
        static void Main(string[] args)
        {  //Escribir por consola
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            Console.WriteLine("Ingrese su nombre");
            string nombre;
            //Leemos por consola
            nombre=Console.ReadLine();

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine();

            Console.WriteLine("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            switch(edad)
            {
                case 17:
                    Console.WriteLine("Usted es menor de edad");
                    break;
                case 18:
                    Console.WriteLine("Usted es mayor de edad");
                    break;
                default:
                    Console.WriteLine("Usted es un NN");
                    break;
            }

            Console.WriteLine();

            const int CANTIDAD_DE_ALUMNOS = 2;
            string[] arrayNombres = new string[CANTIDAD_DE_ALUMNOS];
            int[] arrayEdades = new int[CANTIDAD_DE_ALUMNOS];

            if (CANTIDAD_DE_ALUMNOS < 5)
            {
                Console.WriteLine("Es menor que cinco ");
            }

            for (int i = 0; i < arrayNombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                string name = Console.ReadLine();
                arrayNombres[i] = name;

                Console.WriteLine("Ingrese la edad del alumno: ");
                int age = int.Parse(Console.ReadLine());
                arrayEdades[i] = age;

            }

            int j = 0;

            while (j < CANTIDAD_DE_ALUMNOS)
            {
                Console.WriteLine("El alumno " + arrayNombres[j] + " tiene " + arrayEdades[j] + " años ");
                Console.WriteLine();
                Console.WriteLine("El alumno {0} tiene {1} años", arrayNombres[j], arrayEdades[j]);
                j++;
            }


                //Console.WriteLine("Su edads es: {0}", edad);


                Console.ReadKey();
        }
    }
}

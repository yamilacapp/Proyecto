using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAdicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            char sexo;
            float altura;
            float peso;
            double dni;

            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sexo");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese DNI: ");
            dni=double.Parse(Console.ReadLine());


            Persona persona1 = new Persona(nombre, edad, sexo, dni, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3= new Persona();

            Console.WriteLine(persona1.ToString());

            if (persona1.calcularIMC() == 1)
            {
                Console.WriteLine("La persona esta en sobrepeso");
            }
            else if (persona1.calcularIMC() == 0)
            {
                Console.WriteLine("La persona esta en su peso ideal");
            }
            else
            {
                Console.WriteLine("La persona esta por debajo de su peso");
            }

            if (persona1.EsMayorEdad())
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }

            Console.ReadLine();

        }
    }
}

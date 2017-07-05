using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa2_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu1 = new Alumno();
            Alumno alu2 = new Alumno("Jesus", "Nazareth", 0);
            Alumno alu3 = new Alumno();

            alu1.nombre = "Pedro";
            alu1.apellido = "Apostol";

            alu1.SetDni(29);


            Console.WriteLine(alu1.nombre+": "+alu1.AsistirAClases());

            Console.WriteLine("El DNI de "+alu2.nombre+" es: "+alu2.GetDni());

            Console.WriteLine("La cantidad de alumnos es: " + Alumno.cantAlumnos);

           



            Console.ReadKey();
        }
    }
}

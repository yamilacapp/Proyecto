using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 nuevaClase = new Class1();

            nuevaClase.setApellido("Pastorutti");
            nuevaClase.setNombre("Julian");
            nuevaClase.setDni(335566);

            Console.WriteLine("Pesona datos: "+nuevaClase.GetNombre() +" "+ nuevaClase.GetApellido()+" " + nuevaClase.GetDni());

            Console.ReadKey();

        }
    }
}

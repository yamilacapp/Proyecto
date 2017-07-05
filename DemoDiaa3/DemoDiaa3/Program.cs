using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa3
{
    class Program
    {
        static void Main(string[] args)
        {
            TarjetaIdentificacion tarj = new TarjetaIdentificacion();
            Empleado emp1 = new Empleado("Gabi");
            Empleado emp2 = new Empleado("Mario");
            Empleado emp3 = new Empleado("Matias");
            Supervisor sup = new Supervisor("Dario", "Banco Rio");

            Console.WriteLine(sup.Ingresar(tarj));
            sup.AgregarEmpleados(emp1);
            sup.AgregarEmpleados(emp2);
            sup.AgregarEmpleados(emp3);


            Console.WriteLine(sup.HacerTrabajar());
            Console.WriteLine("El sueldo antes de evaluar es: " + sup.sueldo);

            sup.Evaluar();

            Console.WriteLine("Dario esta triste :(");
            Console.WriteLine("Dario este mes cobra: " + sup.sueldo);
            Console.ReadKey();



        }
    }
}

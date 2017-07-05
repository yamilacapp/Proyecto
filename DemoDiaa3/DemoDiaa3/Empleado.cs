using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa3
{
    class Empleado
    {
        public string nombre;

        public Empleado(string name)
        {
            this.nombre = name;

        }

        public string Trabajar()
        {
            return this.nombre+ ": Tabaja muy duro.. Como un esclavo.. Paguenme dinero";
        }
    }
}

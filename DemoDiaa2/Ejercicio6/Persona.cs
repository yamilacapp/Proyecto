using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;

        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }
             

    }
}

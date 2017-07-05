using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Class1
    {
        private string nombre;
        private string apellido;
        private int dni;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public int GetDni()
        {
            return this.dni;

        }

    }
}

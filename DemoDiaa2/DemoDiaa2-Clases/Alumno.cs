using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDiaa2_Clases
{
    class Alumno
    {   //ATRIBUTOS
        public string nombre, apellido;
        private int dni;
        public static int cantAlumnos;

        //CONSTRUCTOR POR DEFECTO
        public Alumno()
        {
            cantAlumnos++;

        }

        public Alumno(string name, string lastname, int dni)
        {
            this.nombre = name;
            this.apellido = lastname;
            this.dni = dni;
            cantAlumnos++;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public string AsistirAClases()
        {
            return "Hoy tuve clases de Anatomia";
        }

    }
}

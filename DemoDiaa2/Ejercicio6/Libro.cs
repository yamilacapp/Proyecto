using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Libro
    {
        public Persona Autor;
        public string Titulo;
        public string editorial;
        public string Lugar;
        DateTime fecha;
        public int cantPaginas;

        public Libro()
        {
            Autor = new Persona();
            Titulo = "";
            editorial = "";
            Lugar = "";
           fecha = DateTime.Now;
           cantPaginas = 0;
       
            
         }

        public Libro(string nombre, string apellido, string titulo, string editorial, string lugar, int pages):this()
        { 
            
            this.Autor.SetNombre(nombre);
            this.Autor.SetApellido(apellido);
            this.Titulo = titulo;
            this.editorial = editorial;
            this.Lugar = lugar;
            this.cantPaginas = pages;
            this.fecha =new DateTime(2002, 06, 21);

        }

        public void MostrarDatos()
        {
            Console.WriteLine("Titulo: " + this.Titulo);
            Console.WriteLine("Autor: " + this.Autor.GetNombre()+" "+this.Autor.GetApellido());
            Console.WriteLine("Editorial: " + this.editorial);
            Console.WriteLine("Lugar: " + this.Lugar);
            Console.WriteLine("Fecha: " + this.fecha.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("Cantidad de paginas: "+this.cantPaginas);
        }




    }
}

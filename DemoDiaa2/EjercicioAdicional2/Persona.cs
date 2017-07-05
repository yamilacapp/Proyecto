using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAdicional2
{
    class Persona
    {
        private string nombre;
        //private string apellido;
        private int edad;
        private double dni;
        private char sexo;
        private float altura;
        private float peso;
        private const char sexo1='h';


        public Persona()
        {
            this.nombre = "";
           // this.apellido = "";
            this.edad = 0;
            this.sexo = Persona.sexo1;
            this.dni = 11111;
            this.altura = 0;
            this.peso = 0;
            
        }

        public Persona(string nombre, int edad, char sexo): this()
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, char sexo, double dni, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.dni = dni;
            this.peso = peso;
            this.altura = altura;

        }

        public int calcularIMC()
        {
            if (this.peso / this.altura < 10)
            {
                return -1;
            }
            else if (this.peso / this.altura > 10 && this.peso / this.altura < 25)
            {
                return 0;
            }
            else
            {    Console.WriteLine("La persona esta exedida de peso");
            return 1;
            }
        }

        public bool EsMayorEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ComprobarSexo(char sexo)
        {
            if (this.sexo != sexo)
            {
                this.sexo = sexo1;
            }
        }

        public string ToString()
        {
            string edad = Convert.ToString(this.edad);
            //string sexo = Convert.ToChar(this.sexo);
            string altura = Convert.ToString(this.altura);
            string peso = Convert.ToString(this.peso);
            string dni = Convert.ToString(this.dni);

            return (this.nombre+" "+this.sexo + ", " + edad + ", " + altura + ", " + peso + ", " + dni);
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPeso(float peso)
        {
            this.peso = peso;
        }
        public void SetSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public void SetAltura(float altura)
        {
            this.altura = altura;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public float GetPeso()
        {
            return this.peso;
        }

        public float GetAltura()
        {
            return this.altura;
        }

        public char GetSexo()
        {
            return this.sexo;
        }


    }
}

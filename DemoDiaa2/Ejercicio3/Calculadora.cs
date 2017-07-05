using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Calculadora
    {

        public int Sumar(int num, int num2)
        { 
            return (num + num2);
        }

        public int Sumar(int num, int num2, int num3)
        {
            return (num + num2 + num3);
        }

        public float Sumar(float num, float num2)
        {
            return (num + num2);
        }

        public float Sumar(float num, float num2, float num3, float num4)
        {
            return (num + num2 + num3 + num4);
        }

    }
}

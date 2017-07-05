using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAdicional1
{
    class Cafetera
    {
        public int _capacidadMaxima;
        public int _cantidadActual;

        public Cafetera()
        {
            this._cantidadActual=0;
            this._capacidadMaxima=1000; 
        }

        public Cafetera(int cantidadM)
        {
            this._capacidadMaxima = cantidadM;
        }

        public Cafetera(int cantidadM, int cantidadAc)
        {
            if (cantidadM > cantidadAc)
            {
                this._capacidadMaxima = cantidadM;
                this._cantidadActual = cantidadAc;
            }
            else if (cantidadM < cantidadAc)
            {
                this._cantidadActual = cantidadM;
                this._capacidadMaxima = cantidadM;
            }
            else
            {
                this._cantidadActual = cantidadM;
                this._capacidadMaxima = cantidadM;
            }


        }

        public void SetCantMax(int numero)
        {
            this._capacidadMaxima = numero;
        }

        public void SetCantAct(int numero)
        {
            this._cantidadActual = numero;
        }

        public int GetCantMax()
        {
            return this._capacidadMaxima;
        }

        public int GetCantAct()
        {
            return this._cantidadActual;
        }

        public void LlenarCafetera()
        {
            this._cantidadActual = this._capacidadMaxima;
        }

        public void ServirCafe(int numero)
        {
            if (numero > this._cantidadActual)
            {
                this._cantidadActual = 0;
            }
            else
            {
                this._cantidadActual = this._cantidadActual - numero;
            }
        }

        public void VaciarCafetera()
        {
            this._cantidadActual = 0;
        }

        public void AgregarCafe(int numero)
        {
            if (this._cantidadActual != this._capacidadMaxima)
            {
                this._cantidadActual = this._cantidadActual + numero;
            }
            else
            {
                Console.WriteLine("La cafetera esta completa.");
            }
        }
    }
}

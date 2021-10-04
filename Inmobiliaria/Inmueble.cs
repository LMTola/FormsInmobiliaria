using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    class Inmueble
    {
       
        protected double Superficie;
        protected  string Direccion;
        protected double PrecioBase;
        protected int Antiguedad;



        public void Datoinmueble()
        {

           
        }

        public String getDireccion()
        {
            return this.Direccion;
        }
        public Double getSuperficie()
        {
            return this.Superficie;
        }

        public double CalculoPrecio()
        {
            double Preciocalculado = 0;
            if (Antiguedad <= 15 && Antiguedad >= 0)
                Preciocalculado = (PrecioBase * 0.99);
            else if (Antiguedad > 15)
                Preciocalculado = (PrecioBase * 0.98);

            return Preciocalculado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    class Piso : Inmueble
    {
        private int NumeroPîso;


      

        public  Piso(int numeroPiso,double superficie,string direccion,double precioBase,int antiguedad )
        {
            Superficie= superficie;
            Direccion = direccion;
            PrecioBase = precioBase;
            Antiguedad = antiguedad;

            // Numero Planta en la que se encuentra el piso
            NumeroPîso = numeroPiso;

        }
        public double CalculoPrecio()
        {
            double PrecioPiso = 0;
            //super.getPrecioBase();
            if (NumeroPîso >= 3)
                PrecioPiso = (CalculoPrecio() * 1.03);
            else if (NumeroPîso >= 0 && NumeroPîso < 3)
                PrecioPiso = (CalculoPrecio());

            return PrecioPiso;
        }

    }
}

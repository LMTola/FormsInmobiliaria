using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    class Local : Inmueble
    {
        private int Ventanas;
        

        public Local(int numeroventanas, double superficie, string direccion, double precioBase, int antiguedad)
        {
            Superficie = superficie;
            Direccion = direccion;
            PrecioBase = precioBase;
            Antiguedad = antiguedad;
            Ventanas = numeroventanas;

        }
        public double CalculoPrecio()
        {
            double Preciolocal = 0;
           
            if (getSuperficie() > 50)
                Preciolocal = (CalculoPrecio() * 1.01);
            if (Ventanas <= 1)
                Preciolocal = (Preciolocal * 0.98);
            else if (Ventanas >= 4)
                Preciolocal = (Preciolocal * 1.02);

            else if (getSuperficie() >= 1 && getSuperficie() <= 50)
                Preciolocal = (CalculoPrecio());

            return Preciolocal;
        }


    }
}

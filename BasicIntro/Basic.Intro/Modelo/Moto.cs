using Basic.Intro.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Modelo
{
    public class Moto :  IVehiculo
    {
        public Moto()
        {           
        }

        public Moto(string marca)
        {
            Marca = marca;
        }

        public static void DelegateEsMoto(IVehiculo vehiculo)
        {
            if (vehiculo is Moto)
                Console.WriteLine("El " + vehiculo.Marca + "|" + vehiculo.Modelo + " es un moto");
        }
    }
}

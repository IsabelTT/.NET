using Basic.Intro.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Modelo
{
    public sealed class Camion : Vehiculo, IVehiculo
    {
        public Camion() : base(null)
        {
        }

        public Camion(string marca) : base(marca)
        {            
        }

        public Camion(string marca, string modelo) : base(marca)
        {
            Modelo = modelo;
        }

        public static void DelegateEsCamion(IVehiculo vehiculo)
        {
            if (vehiculo is Camion)
                Console.WriteLine("El " + vehiculo.Marca + "|" + vehiculo.Modelo + " es un camion");
        }
    }
}

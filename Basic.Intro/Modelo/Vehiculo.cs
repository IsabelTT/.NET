using Basic.Intro.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Modelo
{
    public abstract class Vehiculo : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public void Arrancar()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Contratos
{
    public interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }

        void Arrancar();
    }
}

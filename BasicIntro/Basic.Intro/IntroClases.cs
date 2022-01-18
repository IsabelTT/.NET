using Basic.Intro.Contratos;
using Basic.Intro.Enumerados;
using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Basic.Intro
{
    public class IntroClases
    {
        public static void GetIntroClases()
        {
            Coche audi = new Coche();
            audi.Marca = "Audi";
            audi.Modelo = "A3";
            audi.Color = Color.Orange;

            Coche coche2 = new Coche("Seat", "Ibiza")
            {
                Color = Color.Red
            };
            coche2.Cambio = Cambio.Automatico;

            ArrancarVehiculo(coche2);

            Console.WriteLine(audi.Marca + " es un vehiculo: " + (audi is IVehiculo));
            Console.WriteLine(audi.Marca + " es un coche: " + (audi is Coche));
            Console.WriteLine(audi.Marca + " es un moto: " + (audi is Moto));
            Console.WriteLine(audi.Marca + " es un camion: " + (audi is Camion));

            Moto suzuki = new Moto();
            ArrancarVehiculo(suzuki);

            Console.WriteLine("El modelo del Audi es " + audi.Modelo);
        }

        static public void ArrancarVehiculo(IVehiculo vehiculo)
        {
            vehiculo.Arrancar();
        }
    }
}

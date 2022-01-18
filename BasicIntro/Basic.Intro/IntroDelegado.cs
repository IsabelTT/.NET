using Basic.Intro.Contratos;
using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    public delegate void Del(char caracter);
    public delegate void FiltroVehiculo(IVehiculo vehiculo);

    public class IntroDelegado
    {
        public static void GetIntroDelegado()
        {
            //Del handler = IntroDelegado.DelegateMethod;
            //handler(Console.ReadKey(true).KeyChar);

            //IVehiculo[] vehiculos = {
            //    new Coche("Seat", "Ibiza"),
            //    new Coche("Ford", "Fiesta"),
            //    new Moto("Honda"){ Modelo = "CBR"},
            //    new Moto("Kawasaki"){ Modelo = "Ninja"},
            //    new Camion("Pegaso"){ Modelo = "Troner"}
            //};

            //IntroDelegado.QuienEsQuien(vehiculos, Coche.DelegateEsCoche);
            //IntroDelegado.QuienEsQuien(vehiculos, Moto.DelegateEsMoto);
            //IntroDelegado.QuienEsQuien(vehiculos, Camion.DelegateEsCamion);

            Coche coche = new Coche();
            coche.Modelo = "MiCarro";
            coche.onModeloChanged = Coche_OnModeloChanged;
            coche.Modelo = "600";

            Coche coche2 = new Coche();
            coche2.onModeloChanged = Coche2_OnModeloChanged;
            coche2.Modelo = "Testarrosa";
        }

        static public void DelegateMethod(char caracter)
        {
            Console.WriteLine("la tecla pulsada es " + caracter);
        }

        public static void QuienEsQuien(IVehiculo[] vehiculos, FiltroVehiculo filtroVehiculo)
        {
            foreach (var vehiculo in vehiculos)
            {
                filtroVehiculo(vehiculo);
            }
        }

        public static void Coche_OnModeloChanged(string modelo)
        {
            Console.WriteLine("El modelo del coche ha cambiado a " + modelo);
        }

        public static void Coche2_OnModeloChanged(string modelo)
        {
        }
    }
}

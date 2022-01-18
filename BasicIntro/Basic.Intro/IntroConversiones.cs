using Basic.Intro.Contratos;
using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Basic.Intro
{
    public class IntroConversiones
    {
        public static void GetIntroConversiones()
        {
            int numero = 123;
            decimal mas = numero; // implicita            
            Console.WriteLine("el valor decimal es " + mas);

            decimal x = 32.5m;
            decimal y = 43.23m;
            var suma = SumaEnteros((int)x, (int)y);
            int sindecimales = (int)x; //explicita
            Console.WriteLine("el valor entero es " + sindecimales);
            float flotante = (float)x;
            Console.WriteLine("el valor es " + flotante);
            
            //boxing
            object o = 55;
            Console.WriteLine("el valor es " + o);
            o = "ola q ase";
            Console.WriteLine("el valor es " + o);
            Coche coche = new Coche { Marca = "BMW", Color = Color.Red };            
            bool esBWM = EsBmw(coche);

            //unboxing
            int num = int.Parse("123");
            Moto moto = new Moto
            {
                Marca = coche.Marca + coche.Modelo
            };

            esBWM = EsBmw(moto);
        }

        static bool EsBmw(IVehiculo vehiculo)
        {
            return vehiculo.Marca == "BMW";
        }
        static int SumaEnteros(int x, int y)
        {
            return x + y;
        }
    }
}

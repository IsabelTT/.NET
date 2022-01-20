using Basic.Intro.Contratos;
using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    public class IntroMatrices
    {
        public static void GetIntroMatrices()
        {
            //array
            int[] primos = { 1, 2, 3, 5, 7 };
            string[] cadenas = { "Anda", "alegrame", "el", "día" };

            int[,] multple = { 
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 11,12,13,14,15} 
            };

            IVehiculo[] vehiculos = { 
                new Coche("Dacia"), 
                new Coche("Ford"),
                new Moto("Yamaha"),
                new Camion("MAN")
            };

            Console.WriteLine(vehiculos[2].Marca);
        }
    }
}

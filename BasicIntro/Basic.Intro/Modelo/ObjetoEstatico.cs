using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Modelo
{
    //ref: https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
    public static class ObjetoEstatico
    {
        public static int Sumatorio { get; set; }

        public static int Suma(int a, int b)
        {
            Sumatorio = Sumatorio + a + b;
            return a + b;
        }
    }

    public class ObjetoNoEstatico
    {
        public int Suma(int a, int b)
        {
            ObjetoEstatico.Sumatorio = ObjetoEstatico.Sumatorio + a + b;
            return a + b;
        }

        public static int Resta(int a, int b)
        {
            return a - b;
        }
    }
}

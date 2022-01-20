using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    class IntroTipos
    {
        static public void GetIntroTipos()
        {
            Console.WriteLine("sbyte minimo valor " + sbyte.MinValue);
            Console.WriteLine("sbyte maximo valor " + sbyte.MaxValue);

            Console.WriteLine("byte minimo valor " + byte.MinValue);
            Console.WriteLine("byte maximo valor " + byte.MaxValue);

            Console.WriteLine("short minimo valor " + short.MinValue);
            Console.WriteLine("short maximo valor " + short.MaxValue);

            Console.WriteLine("ushort minimo valor " + ushort.MinValue);
            Console.WriteLine("ushort maximo valor " + ushort.MaxValue);

            int entero = 9;

            Console.WriteLine("int minimo valor " + int.MinValue);
            Console.WriteLine("int maximo valor " + int.MaxValue);

            Console.WriteLine("uint minimo valor " + uint.MinValue);
            Console.WriteLine("uint maximo valor " + uint.MaxValue);

            Console.WriteLine("long minimo valor " + long.MinValue);
            Console.WriteLine("long maximo valor " + long.MaxValue);

            Console.WriteLine("ulong minimo valor " + ulong.MinValue);
            Console.WriteLine("ulong maximo valor " + ulong.MaxValue);

            char caracter = 'f';

            Console.WriteLine("char solo permite una caracter -> " + caracter);

            Console.WriteLine("float minimo valor " + float.MinValue);
            Console.WriteLine("float maximo valor " + float.MaxValue);

            float flotante = 0.95443F;
            Console.WriteLine("flotante valor: " + flotante);

            Console.WriteLine("double minimo valor " + double.MinValue);
            Console.WriteLine("double maximo valor " + double.MaxValue);

            double doble = 0.8D;
            Console.WriteLine("doble valor: " + doble);

            Console.WriteLine("Decimal minimo valor " + Decimal.MinValue);
            Console.WriteLine("Decimal maximo valor " + Decimal.MaxValue);

            decimal decimales = 30.32m;
            Console.WriteLine("decimal valor: " + decimales);

            bool verdadero = true;
            bool falso = false;

            Console.WriteLine("true valor: " + verdadero);
            Console.WriteLine("false valor: " + falso);

            float? nulo = null;
            Console.WriteLine("valor nulo: " + nulo);
        }
    }
}

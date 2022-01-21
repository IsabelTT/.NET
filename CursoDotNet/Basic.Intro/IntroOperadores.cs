using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    public class IntroOperadores
    {
        public static void GetIntroOperadores()
        {
            int suma = 2 + 4;
            Console.WriteLine("valor de suma: " + suma);
            int resta = 2 - 1;
            Console.WriteLine("valor de resta: " + resta);
            int incremento = ++resta;
            Console.WriteLine("valor de incremento: " + incremento);
            int decremento = suma--;
            Console.WriteLine("valor de decremento: " + decremento);

            bool mentira = !true;
            Console.WriteLine("mentira tiene valor " + mentira);
            Console.WriteLine("mentira no tiene valor " + !mentira);

            Console.WriteLine("2 más 2 son 4 => " + (2 + 2 == 4));
            Console.WriteLine("2 más 2 no son 7 => " + (2 + 2 != 7));
            Console.WriteLine("2 más 2 es mayor que 3 => " + (2 + 2 >= 3));
            Console.WriteLine("2 más 2 es menor que 5 => " + (2 + 2 <= 5));

            Coche coche = null;
            if (coche?.Modelo != null)
                Console.WriteLine("modelo no nulo");


            Console.WriteLine("coche nulo => " + coche?.Modelo);
        }
    }
}

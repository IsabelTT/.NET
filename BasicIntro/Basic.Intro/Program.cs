using Basic.Intro.Modelo;
using System;

namespace Basic.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("Cosa");

            IntroMetodos metodos = IntroMetodos.Instance;
            metodos.Metodo(null);

            //

            IntroMetodos metodos2 = IntroMetodos.Instance;
            IntroMetodos metodos3 = IntroMetodos.Instance;
            IntroMetodos metodos4 = IntroMetodos.Instance;


            //IntroMetodos.GetIntroMetodos();


            Console.WriteLine("Pulse cualquier letra para salir...");
            Console.ReadKey();
        }
    }
}

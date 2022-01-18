using Basic.Intro.Contratos;
using Basic.Intro.Enumerados;
using Basic.Intro.Excepciones;
using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    public class IntroEstructuras
    {
        public static void GetIntroEstructuras()
        {
            //if
            bool condicion = true;
            int suma = 2 + 4;
            if (condicion & SecondOperand())
            {
                Console.WriteLine("La condicion se cumple");
            }
            if (condicion && SecondOperand())
            {
                Console.WriteLine("La condicion se cumple");
            }

            if (condicion)
            {
                Console.WriteLine("La condicion se cumple");
            }
            else
            {
                Console.WriteLine("todo es mentira");
            }

            if (condicion)
            {
                Console.WriteLine("La condicion se cumple");
            }
            else if (SecondOperand())
            {
                Console.WriteLine("La condicion se cumple");
            }
            else
            {
                Console.WriteLine("todo es mentira");
            }

            bool a = !condicion && SecondOperand();
            Console.WriteLine("resultado de a: " + a);

            bool b = condicion && SecondOperand();
            Console.WriteLine("resultado de b: " + b);

            string cadena = "Adios";
            switch (cadena.ToUpper())
            {
                case "HOLA":
                    Console.WriteLine("Saludos");
                    break;
                case "Adios":
                case "Hasta luego":
                    Console.WriteLine("Nos vemos");
                    break;
                case "gfg3hFD":

                    break;
                default:
                    Console.WriteLine("Nada");
                    break;
            }

            //do
                int numero = 1;
            do
            {
                Console.WriteLine("contador " + numero++);
            } while (numero < 10);

            while (numero > 10)
            {
                Console.WriteLine("contador " + numero--);
            }

            for (int i = 0; i < 100; i++)
            {
            }

            int[] primos = { 1, 2, 3, 5, 7, 11 };
            foreach (var primo in primos)
            {
                Console.WriteLine(primo + " es un numero primo");
            }

            IVehiculo[] vehiculos = {
                new Coche("Ford"),
                new Coche("Dacia"),
                new Moto(){ Marca = "Yamaha"},
                new Camion("MAN")
            };

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Marca);
            }

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Marca == "Dacia")
                    continue;

                Console.WriteLine(vehiculo.Marca);
            }

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Marca == "Dacia")
                    break;

                Console.WriteLine(vehiculo.Marca);
            }

            IEnumerable<int> numeros = GetNumeros2();

            Coche coche1 = new Coche();
            coche1.Marca = "Dacia";
            GetMetodo(coche1.Marca);

            try
            {
                int cero = 1;
                var div = 1 / cero;

                Coche coche = new Coche();
                coche.Marca = "Dacia";

                GetMetodo(coche.Marca);
            }
            catch (NullReferenceException exNull)
            {
                Console.WriteLine("se ha producido un error:" + exNull.Message);

            }
            catch (DivideByZeroException exZero)
            {
                Console.WriteLine("Estas dividiendo entre cero " + exZero.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Que ha pasao!!!!");
            }
            finally
            {
                Console.WriteLine("Yo me pinto siempre");
            }
        }

        public static void GetMetodo(string marca)
        {
            if (marca == "Dacia")
            {
                throw new DaciaExcepcion("son extremadamente baratos");
            }

            //dosomething
        }

        public static bool SecondOperand()
        {
            Console.WriteLine("Entra en la funcion");
            return true;
        }

        public static void Method(IVehiculo vehiculo)
        {
            if (vehiculo.Marca != "Dacia")
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                if (vehiculo.Modelo == "Sandero")
                {

                }
            }
        }

        public static IEnumerable<int> GetNumeros()
        {
            List<int> numero = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                numero.Add(i);
            }

            return numero;
        }

        public static IEnumerable<int> GetNumeros2()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i;
            }
        }
    }
}

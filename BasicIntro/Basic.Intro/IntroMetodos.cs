using Basic.Intro.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro
{
    public class IntroMetodos
    {
        private static IntroMetodos instance;
        public static IntroMetodos Instance
        {
            get
            {
                //if (instance == null)
                    instance = new IntroMetodos();

                return instance;
            }
        }

        private IntroMetodos()
        { }

        public static void GetIntroMetodos()
        {
            Moto moto = new Moto();
            moto.Modelo = "";

            IntroMetodos metodo = new IntroMetodos();
            ClaseMetodo parametro = new ClaseMetodo
            {
                cadena = "",
                fecha = DateTime.Now,
                SiNo = true
            };
            metodo.Metodo(parametro);
        }

        public void GetIntroMetodosEstaticos()
        {
            var cinco = ObjetoEstatico.Suma(2, 3);
            Console.WriteLine(cinco);
            Console.WriteLine(ObjetoEstatico.Sumatorio);

            ObjetoNoEstatico noEstatico = new ObjetoNoEstatico();
            var nueve = noEstatico.Suma(4, 5);
            var dos = ObjetoNoEstatico.Resta(5, 3);

            ObjetoNoEstatico noEstatico2 = new ObjetoNoEstatico();
            var doce = noEstatico.Suma(8, 4);

            Console.WriteLine(ObjetoEstatico.Sumatorio);
        }

        public void Metodo(ClaseMetodo parametros)
        {
            //algo

            //algo mas
        }

        public int Funcion()
        {
            if (DateTime.UtcNow.Minute == 18)
            {
                return 0;
            }

            return 1;
        }
    }
}

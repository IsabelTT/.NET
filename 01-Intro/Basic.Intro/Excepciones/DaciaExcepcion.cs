using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Intro.Excepciones
{
    public class DaciaExcepcion: ArgumentException
    {
        public string Porque { get; set; }

        public DaciaExcepcion(string Porque)
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaa");
        }
    }
}

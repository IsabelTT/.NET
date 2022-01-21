using System;
using System.Collections.Generic;
using System.Linq;

namespace MyEmpresa.Entidades
{
    public class Caja
    {
        //variables
        static Random rnd = new Random(DateTime.Now.Millisecond);

        //Propiedades
        //public Guid Id { get; private set; }
        public IEnumerable<Caja> Cajas { get; set; }

        //Constructor
        public Caja()
        {
            //Id = Guid.NewGuid();
        }

        //Funciones
        public List<Caja> RandomCajas()
        {
            var elementos = rnd.Next(0, 5);
            List<Caja> muchasCajas = new List<Caja>();

            for (int i = 0; i < elementos; i++)
            {
                //Creacion de instancia + asignacion de propiedad
                muchasCajas.Add(new Caja() { Cajas = RandomCajas() });
            }

            return muchasCajas;
        }

        public static int Contar(Caja caja)
        {
            int contador = 1;

            foreach (var cajita in caja.Cajas.ToList())
            {
                contador += Contar(cajita);
            }

            return contador;
        }
    }
}

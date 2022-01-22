using System;
using System.Linq;
using System.Collections.Generic;

namespace MyEmpresa.Model
{
    public sealed class Division : Organizacion
    {
        public List<Area> Areas { get; set; }

        public Division(string nombre, string descripcion) : base(nombre, descripcion)
        { 
        
        }

        public Division(string nombre, string descripcion, List<Area> areas) : base(nombre, descripcion)
        {
            Areas = areas;
        }

        public override void Crear()
        {
            //Conectar BBDD

            var insert = $"insert Division (Id, Nombre, Descripcion, FechaCreacion) values ({Id}, {Nombre}, {Descripcion}, {FechaCreacion})";

            if (Areas.Any())
            {
                foreach (var area in Areas)
                {
                    area.Crear();
                }
            }
        }
    }
}

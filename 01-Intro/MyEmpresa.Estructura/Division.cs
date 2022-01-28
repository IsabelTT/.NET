using System;
using System.Linq;
using System.Collections.Generic;
using MyEmpresa.Model;

namespace MyEmpresa.Estructura
{
    public sealed class Division : Organizacion, IOrganizacion
    {
        public List<ISegundoNivel> SegundoNiveles { get; set; }

        public Division() : base()
        { }

        public Division(string nombre, string descripcion) : base(nombre, descripcion)
        { 
        
        }

        public Division(string nombre, string descripcion, List<Area> areas) : base(nombre, descripcion)
        {
            SegundoNiveles = areas.Cast<ISegundoNivel>().ToList();
        }

        public override void Crear()
        {
            //Conectar BBDD

            var insert = $"insert Division (Id, Nombre, Descripcion, FechaCreacion) values ({Id}, {Nombre}, {Descripcion}, {FechaCreacion})";

            if (SegundoNiveles.Any())
            {
                foreach (var area in SegundoNiveles)
                {
                    //area.Crear();
                }
            }
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }
    }
}

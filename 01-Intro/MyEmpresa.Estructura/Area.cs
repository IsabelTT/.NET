using System;
using System.Collections.Generic;
using System.Linq;
using MyEmpresa.Model;

namespace MyEmpresa.Estructura
{
    public sealed class Area : Organizacion, ISegundoNivel
    {
        public IOrganizacion Organizacion { get; set; }
        public List<ITercerNivel> TercerNiveles { get; set; }

        public Area() : base()
        { }

        public Area(string nombre, string descripcion) : base(nombre, descripcion)
        {
        }

        public Area(string nombre, string descripcion, Division division) : base(nombre, descripcion)
        {
            Organizacion = division;
        }

        public Area(string nombre, string descripcion, List<Zona> zonas) : base(nombre, descripcion)
        {
            TercerNiveles = zonas.Cast<ITercerNivel>().ToList();
        }

        public Area(string nombre, string descripcion, Division division, List<Zona> zonas) : base(nombre, descripcion)
        {
            Organizacion = division;
            TercerNiveles = zonas.Cast<ITercerNivel>().ToList();
        }

        public override void Crear()
        {
            var insert = $"insert Area (Id, Nombre, Descripcion, IdDivision, FechaCreacion) values ({Id}, {Nombre}, {Descripcion}, {Organizacion.Id}, {FechaCreacion})";

            if (TercerNiveles.Any())
            {
                foreach (var zona in TercerNiveles)
                {
                    //zona.Crear();
                }
            }
        }
    }
}

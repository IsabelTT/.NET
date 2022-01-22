using System;
using System.Collections.Generic;
using System.Linq;

namespace MyEmpresa.Model
{
    public sealed class Area : Organizacion
    {
        public Division Division { get; set; }
        public List<Zona> Zonas { get; set; }

        public Area(string nombre, string descripcion) : base(nombre, descripcion)
        {            
        }

        public Area(string nombre, string descripcion, Division division) : base(nombre, descripcion)
        {
            Division = division;
        }

        public Area(string nombre, string descripcion, List<Zona> zonas) : base(nombre, descripcion)
        {
            Zonas = zonas;
        }

        public Area(string nombre, string descripcion, Division division, List<Zona> zonas) : base(nombre, descripcion)
        {
            Division = division;
            Zonas = zonas;
        }

        public override void Crear()
        {
            var insert = $"insert Area (Id, Nombre, Descripcion, IdDivision, FechaCreacion) values ({Id}, {Nombre}, {Descripcion}, {Division.Id}, {FechaCreacion})";

            if (Zonas.Any())
            {
                foreach (var zona in Zonas)
                {
                    zona.Crear();
                }
            }
        }
    }
}

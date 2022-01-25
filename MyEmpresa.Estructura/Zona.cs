using System;
using System.Collections.Generic;
using System.Text;
using MyEmpresa.Model;

namespace MyEmpresa.Estructura
{
    public sealed class Zona : Organizacion, ITercerNivel
    {
        public Area Area { get; set; }

        public Zona() : base()
        { }

        public Zona(string nombre, string descripcion) : base(nombre, descripcion)
        {
        }

        public Zona(string nombre, string descripcion, Area area) : base(nombre, descripcion)
        {
            Area = area;
        }

        public override void UpdateFechaCreacion()
        {
            FechaCreacion = FechaCreacion.AddDays(-1);
        }

        public override void Crear()
        {
            var insert = $"insert Zone (Id, Nombre, Descripcion, IdDivision, FechaCreacion) values ({Id}, {Nombre}, {Descripcion}, {Area.Id}, {FechaCreacion})";
        }
    }
}

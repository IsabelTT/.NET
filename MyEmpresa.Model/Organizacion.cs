using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public abstract class Organizacion
    {
        public Guid Id { get; protected set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; protected set; }

        public Organizacion(string nombre, string descripcion)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            FechaCreacion = DateTime.Now;
        }

        public virtual void UpdateFechaCreacion()
        {
            FechaCreacion = DateTime.Now;
        }

        public abstract void Crear();
    }
}

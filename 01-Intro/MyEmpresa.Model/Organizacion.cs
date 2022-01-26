using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public abstract class Organizacion
    {
        private string nombre;

        public Guid Id { get; set; }
        //Ejemplo de la utilizacion del {this}
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Organizacion()
        {
        }

        public Organizacion(string nombre, string descripcion)
        {
            this.Id = Guid.NewGuid();
            this.nombre = nombre;
            this.Descripcion = descripcion;
            this.FechaCreacion = DateTime.Now;
        }

        public virtual void UpdateFechaCreacion()
        {
            FechaCreacion = DateTime.Now;
        }

        public abstract void Crear();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public interface IOrganizacion
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }        

        void Crear();
        void Actualizar();
    }
}

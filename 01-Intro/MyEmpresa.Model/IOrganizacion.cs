using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    //Comunidades y Divisiones
    public interface IOrganizacion
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }        
        List<ISegundoNivel> SegundoNiveles { get; set; }

        void Crear();
        void Actualizar();
    }
}

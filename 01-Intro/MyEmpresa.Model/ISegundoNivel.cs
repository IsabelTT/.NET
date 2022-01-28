using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    //Provincias y Areas
    public interface ISegundoNivel 
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }
        IOrganizacion Organizacion { get; set; }
        List<ITercerNivel> TercerNiveles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public interface ISegundoNivel 
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }
    }
}

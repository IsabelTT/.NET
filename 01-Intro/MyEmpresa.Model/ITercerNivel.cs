using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public interface ITercerNivel
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }
    }
}

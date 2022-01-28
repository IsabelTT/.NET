using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    //Ciudades y Zonas
    public interface ITercerNivel
    {
        Guid Id { get; set; }
        string Nombre { get; set; }
        DateTime FechaCreacion { get; set; }
        ISegundoNivel SegundoNivel { get; set; }
    }
}

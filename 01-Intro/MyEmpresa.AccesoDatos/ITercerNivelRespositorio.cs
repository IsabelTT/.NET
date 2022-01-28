using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    public interface ITercerNivelRespositorio
    {
        void Crear(Model.ITercerNivel nivel);
        void Actualizar(Model.ITercerNivel nivel);
    }
}

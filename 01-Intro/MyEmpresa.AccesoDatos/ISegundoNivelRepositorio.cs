using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    public interface ISegundoNivelRepositorio
    {
        void Crear(Model.ISegundoNivel nivel);
        void Actualizar(Model.ISegundoNivel nivel);
    }
}

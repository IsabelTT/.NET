using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    //Repositorio para segundos niveles (Provincias y Areas)
    public class SegundoNivelRepositorio : ISegundoNivelRepositorio
    {
        private IDbConnection connection;

        public SegundoNivelRepositorio(IDbConnection connection)
        {
            this.connection = connection;
        }

        public void Actualizar(ISegundoNivel nivel)
        {
        }

        public void Crear(ISegundoNivel nivel)
        {
        }
    }
}

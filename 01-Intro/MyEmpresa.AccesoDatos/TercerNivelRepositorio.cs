using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    //Repositorio para terceros niveles (Ciudades y Zonas)

    public class TercerNivelRepositorio : ITercerNivelRespositorio
    {
        private IDbConnection connection;

        public TercerNivelRepositorio(IDbConnection connection)
        {
            this.connection = connection;
        }

        public void Actualizar(ITercerNivel nivel)
        {

        }

        public void Crear(ITercerNivel nivel)
        {
        }
    }
}

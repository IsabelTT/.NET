using Microsoft.Extensions.Logging;
using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    //Repositorio para primeros niveles (Comunidad y Divisiones)
    public class OrganizacionRespositorio: IOrganizacionRespositorio
    {
        private IDbConnection dbConnection;

        public OrganizacionRespositorio(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public void Crear(IOrganizacion org)
        {
        }

        public void Actualizar(IOrganizacion org)
        {
        }
    }
}

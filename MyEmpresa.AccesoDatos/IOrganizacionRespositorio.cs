using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.AccesoDatos
{
    public interface IOrganizacionRespositorio
    {
        void Crear(IOrganizacion organizacion);
        void Actualizar(IOrganizacion organizacion);
    }
}

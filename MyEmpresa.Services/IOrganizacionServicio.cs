using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Servicios
{
    public interface IOrganizacionServicio
    {
        void Guardar(IOrganizacion org);
    }
}

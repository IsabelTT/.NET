using MyEmpresa.AccesoDatos;
using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MyEmpresa.Servicios
{
    public class OrganizacionServicio : IOrganizacionServicio
    {
        private IOrganizacionRespositorio respositorio;

        public OrganizacionServicio(IOrganizacionRespositorio respositorio)
        {
            this.respositorio = respositorio;
        }

        public void Guardar(IOrganizacion org)
        {
            try
            {
                respositorio.Crear(org);
            }
            catch (DbException) //Error de clave duplicada
            {
                respositorio.Actualizar(org);
            }
            catch (Exception)
            { 
                //guardar en log
            }
        }
    }
}

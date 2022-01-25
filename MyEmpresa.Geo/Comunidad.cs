using System;
using System.Collections.Generic;

namespace MyEmpresa.Geo
{
    public class Comunidad: MyEmpresa.Model.Organizacion, MyEmpresa.Model.IOrganizacion
    {
        public List<Provincia> Provincias { get; set; }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        public override void Crear()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Model
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string CIF { get; set; }
        public List<IOrganizacion> Organizaciones { get; set; }
    }
}

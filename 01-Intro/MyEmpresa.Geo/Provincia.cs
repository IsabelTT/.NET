using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Geo
{
    public class Provincia : MyEmpresa.Model.Organizacion, Model.ISegundoNivel
    {  
        public Model.IOrganizacion Organizacion { get; set; }
        public List<Model.ITercerNivel> TercerNiveles { get; set; }

        public override void Crear()
        {
            
        }
    }
}

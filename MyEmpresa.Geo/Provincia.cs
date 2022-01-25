using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Geo
{
    public class Provincia : MyEmpresa.Model.Organizacion, Model.ISegundoNivel
    {  
        public Comunidad Comunidad { get; set; }
        public List<Ciudad> Ciudades { get; set; }

        public override void Crear()
        {
            
        }
    }
}

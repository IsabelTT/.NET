using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa.Geo
{
    public class Ciudad : MyEmpresa.Model.Organizacion, Model.ITercerNivel
    { 
        public Provincia Provincia { get; set; }

        public override void Crear()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Entities
{
    public class Breed : EntityIdBase
    {
        public string IdSpecies { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Breed : EntityIdBase
    {
        public Guid IdSpecies { get; set; }
        public string Name { get; set; }
    }
}

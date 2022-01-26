using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Species : EntityIdBase
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
    }
}

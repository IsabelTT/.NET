using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public abstract class EntityBase
    {
        public DateTime Updated { get; set; }
        public bool IsRemoved { get; set; }
    }
}

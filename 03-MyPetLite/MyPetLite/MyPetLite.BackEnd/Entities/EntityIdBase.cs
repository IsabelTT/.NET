using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Entities
{
    public abstract class EntityIdBase : EntityBase
    {
        public string Id { get; set; }
    }
}

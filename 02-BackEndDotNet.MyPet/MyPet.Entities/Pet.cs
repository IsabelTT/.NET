using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Pet : EntityIdBase
    {
        public string Name { get; set; }
        public Guid IdBreed { get; set; }
        public Guid IdGender { get; set; }
        public DateTime Birth { get; set; }
        public Guid IdOwner { get; set; }
    }
}

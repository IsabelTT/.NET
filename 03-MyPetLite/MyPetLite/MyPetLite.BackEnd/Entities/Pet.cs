using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Entities
{
    public class Pet : EntityIdBase
    {
        public string Name { get; set; }
        public string IdBreed { get; set; }
        public string IdGender { get; set; }
        public DateTime Birth { get; set; }
        public string IdOwner { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Model
{
    public class Animal
    {
        public string Name { get; set; }
        public Guid IdBreed { get; set; }
        public Guid IdGender { get; set; }
        public DateTime Birth { get; set; }
    }
}

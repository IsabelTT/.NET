using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Veterinary : EntityIdBase
    {
        public string Name { get; set; }
        public string VeterinaryNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

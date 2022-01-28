using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NIF { get; set; }
        public int PhoneNumber { get; set; }
        public IEnumerable<Animal> Animals { get; set; }
    }
}

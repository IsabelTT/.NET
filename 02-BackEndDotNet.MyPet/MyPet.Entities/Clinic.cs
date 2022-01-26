using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyPet.Entities
{
    [Table(nameof(Clinic))]
    public class Clinic : EntityIdBase
    {
        [Column(nameof(Name))]
        public string Name { get; set; }
        [Column(nameof(Address))]
        public string Address { get; set; }
        [Column(nameof(PhoneNumber))]
        public int PhoneNumber { get; set; }
        [Column(nameof(Email))]
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class ClinicVeterinary : EntityBase
    {
        public Guid IdClinic { get; set; }
        public Guid IdVeterinary { get; set; }
    }
}

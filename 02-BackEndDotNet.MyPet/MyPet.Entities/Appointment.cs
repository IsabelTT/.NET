using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Appointment : EntityIdBase
    {
        public Guid IdVeterinary { get; set; }
        public Guid IdClinic { get; set; }
        public Guid IdPet { get; set; }
        public DateTime Date { get; set; }
        public string Observations { get; set; }
        public bool Urgency { get; set; }
    }
}

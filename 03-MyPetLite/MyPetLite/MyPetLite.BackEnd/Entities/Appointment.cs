using System;
using System.Collections.Generic;
using System.Text;

namespace MyPetLite.BackEnd.Entities
{
    public class Appointment : EntityIdBase
    {
        public string IdVeterinary { get; set; }
        public string IdClinic { get; set; }
        public string IdPet { get; set; }
        public DateTime Date { get; set; }
        public string Observations { get; set; }
        public bool Urgency { get; set; }
    }
}

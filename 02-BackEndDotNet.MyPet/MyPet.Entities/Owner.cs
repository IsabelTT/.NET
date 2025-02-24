﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Entities
{
    public class Owner : EntityIdBase
    {
        public string Name { get; set; }
        public string NIF { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

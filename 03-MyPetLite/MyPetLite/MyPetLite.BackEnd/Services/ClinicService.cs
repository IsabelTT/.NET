using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyPetLite.BackEnd.Services
{
    //Servicio para obtener veterinarios
    //      busqueda por clinica
    //      busqueda por especialista
    //      busqueda por veterinario

    public class ClinicService
    {
        public IEnumerable<object> GetVetByClinic(Guid idClinic, DateTime? date)
        {
            if (date == null)
                date = DateTime.Now;

            return null;
        }

        public IEnumerable<object> GetVetSpecialist(Guid idSpecies, DateTime? date)
        {
            return null;
        }
    }
}

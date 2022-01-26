using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Abstract
{
    public interface IAppointmentRespository: IRepositoryBase
    {
        IEnumerable<Entities.Appointment> GetAppointmentByPet(Guid idPet);
        IEnumerable<Entities.Appointment> GetAppointmentByClinic(Guid idClinic);
        IEnumerable<Entities.Appointment> GetAppointmentByVeterinary(Guid idClinic);
    }
}

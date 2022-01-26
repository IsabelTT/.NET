using MyPet.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyPet.DataAccess
{
    public class AppointmentRespository : RepositoryBase, IAppointmentRespository
    {
        private IDbConnection connection;

        public AppointmentRespository(IDbConnection connection) : base(connection)
        {
            this.connection = connection;
        }

        public IEnumerable<Entities.Appointment> GetAppointmentByPet(Guid idPet)
        {
            return null;
        }

        public IEnumerable<Entities.Appointment> GetAppointmentByClinic(Guid idClinic)
        {
            return null;
        }

        public IEnumerable<Entities.Appointment> GetAppointmentByVeterinary(Guid idVeterinary)
        {
            return null;
        }
    }
}

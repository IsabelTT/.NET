using MyPet.Abstract;
using MyPet.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace MyPet.DataAccess
{
    public class ClinicRespository : RepositoryBase, IClinicRepository
    {
        public ClinicRespository(IDbConnection connection) : base(connection)
        {
        }

        public override IEnumerable<Entities.EntityIdBase> GetAll()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                return connection.Query<Entities.Clinic>("SELECT * FROM Clinic");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public override EntityIdBase Get(Guid id)
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                return connection.QueryFirst<Entities.Clinic>("SELECT * FROM Clinic WHERE Id = @id", new { id });
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public override void Insert(EntityIdBase entity)
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var clinic = (Clinic)entity;

                connection.Execute("INSERT Clinic (Id, Name, Address, PhoneNumber, Email) VALUE (@Id, @Name, @Address, @PhoneNumber, @Email)",
                    new { clinic.Id, clinic.Name, clinic.Address, clinic.PhoneNumber, clinic.Email });
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public override void Update(EntityIdBase entity)
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var clinic = (Clinic)entity;

                connection.Execute("UPDATE Clinic SET Name = @Name, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email WHERE Id = @Id",
                    new { clinic.Id, clinic.Name, clinic.Address, clinic.PhoneNumber, clinic.Email });
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}

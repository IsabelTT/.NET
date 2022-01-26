using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace MyPet.DataAccess
{
    public abstract class RepositoryBase
    {
        protected const string connectionString = "server=localhost;port=3306;user=apolo;database=mypet;password=*Apolo2022;";
        protected IDbConnection connection;

        public RepositoryBase(IDbConnection connection)
        {
            this.connection = connection;
        }

        public virtual IEnumerable<Entities.EntityIdBase> GetAll()
        {
            connection.ConnectionString = connectionString;
            connection.Open();        

            var entities =  connection.Query<Entities.Clinic>($"select * from ");

            connection.Close();

            return entities;
        }

        public virtual Entities.EntityIdBase Get(Guid id)
        {
            return null;
        }

        public virtual void Insert(Entities.EntityIdBase entity)
        {
            connection.ConnectionString = connectionString;
            connection.Open();

            var entities = connection.Execute($"insert clinic (Id, Name, Address, PhoneNumber, Email) values (@Id, @Name)", new { entity.Id });

            connection.Close();
        }

        public virtual void Update(Entities.EntityIdBase entity)
        { 
        
        }

        public virtual void Delete(Guid id)
        { 
        
        }
    }
}

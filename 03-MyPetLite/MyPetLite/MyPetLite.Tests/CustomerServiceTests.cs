using Dapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPetLite.BackEnd.Services;
using System;
using System.Collections.Generic;

namespace MyPetLite.Tests
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateCustomer_NullCustomer_Throw()
        {
            CustomerService serv = new CustomerService();
            serv.CreateCustomer(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateCustomer_EmptyName_Throw()
        {
            CustomerService serv = new CustomerService();
            serv.CreateCustomer(new BackEnd.Model.Customer());
        }

        ///Tests de validacion de datos de entrada

        [TestMethod]
        public void CreateCustomer_Full_Ok()
        {
            var petName = Guid.NewGuid().ToString();
            var ownerName = Guid.NewGuid().ToString();

            CustomerService serv = new CustomerService();
            IList<BackEnd.Model.Animal> animals = new List<BackEnd.Model.Animal>();
            animals.Add(new BackEnd.Model.Animal
            {
                Name = petName,
                IdBreed = new Guid("6c71c041-7f5e-11ec-b4d8-025041000001"),
                IdGender = new Guid("6c71bff1-7f5e-11ec-b4d8-025041000001"),
                Birth = new DateTime(2019, 2, 7)
            });
            BackEnd.Model.Customer customer = new BackEnd.Model.Customer
            {
                Name = ownerName,
                NIF = "43841440J",
                PhoneNumber = 916578384,
                Animals = animals
            };

            try
            {
                serv.CreateCustomer(customer);

                //Comprobar si realmente en bbdd se a guardado la info
            }
           finally
            {

                //Eliminar los datos q hemos introducido, para dejar la bbdd como la encontramos antes de ejecutar el test
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;user=apolo;database=mypet;password=*Apolo2022;");
                conn.Open();
                conn.Execute($"DELETE FROM PET WHERE Name = '{petName}'");
                conn.Execute($"DELETE FROM OWNER WHERE Name = '{ownerName}'");
                conn.Close();
            }

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace MyPetLite.BackEnd.Services
{
    public class CustomerService
    {
        public void CreateCustomer(Model.Customer customer)
        {
            //validaciones de datos
            if (customer == null)
                throw new Exception("Cliente es obligatorio");

            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                throw new Exception("Nombre de cliente es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(customer.NIF))
                throw new Exception("NIF del cliente es obligatorio");
            if (!customer.Animals.Any())
            {
                throw new Exception("Los datos de la mascota son obligatorios");
            }
            foreach (var animal in customer.Animals)
            {
                if (string.IsNullOrWhiteSpace(animal.Name))
                    throw new Exception("El nombre del animal es obligatorio");
                if (animal.IdBreed == Guid.Empty)
                    throw new Exception("La raza del animal es obligatoria");
                if (animal.IdGender == Guid.Empty)
                    throw new Exception("El sexo del animal es obligatorio");
            }

            //  comprobar que realmente no este dado de alta
            using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=apolo;database=mypet;password=*Apolo2022;"))
            {
                conn.Open();

                var query = "SELECT * FROM Owner WHERE Name = @Name or NIF = @NIF or PhoneNumber = @PhoneNumber";
                var exists = conn.Query(query, new { customer.Name, customer.NIF, customer.PhoneNumber });

                if (exists.Any())
                    throw new Exception("El cliente ya existe");

                foreach (var animal in customer.Animals)
                {
                    var breed = conn.QueryFirstOrDefault("SELECT * FROM Breed WHERE Id = @IdBreed", new { animal.IdBreed });
                    if (breed == null)
                    {
                        throw new Exception($"La raza de {animal.Name} no se ha encontrado");
                    }
                }

                //conversion de tipos (modelo a entidades de BBDD)
                //Mapper
                Entities.Owner owner = new Entities.Owner
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"{customer.Name} {customer.LastName}",
                    NIF = customer.NIF,
                    PhoneNumber = customer.PhoneNumber.ToString(),
                    Address = null,
                    Email = null
                };

                IList<Entities.Pet> pets = new List<Entities.Pet>();
                foreach (var animal in customer.Animals)
                {
                    Entities.Pet pet = new Entities.Pet
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = animal.Name,
                        IdBreed = animal.IdBreed.ToString(),
                        IdGender = animal.IdGender.ToString(),
                        Birth = animal.Birth,
                        IdOwner = owner.Id.ToString()
                    };

                    pets.Add(pet);
                }

                //guardar datos en BBDD
                conn.Execute($"INSERT Owner (Id, Name, NIF, PhoneNumber, Address, Email) value (@Id, @Name, @NIF, @PhoneNumber, @Address, @Email)",
                    new { owner.Id, owner.Name, owner.NIF, owner.PhoneNumber, owner.Address, owner.Email });
                foreach (var pet in pets)
                {
                    conn.Execute($"INSERT Pet (Id, Name, IdBreed, IdGender, Birth, IdOwner) value (@Id, @Name, @IdBreed, @IdGender, @Birth, @idOwner)",
                        new { pet.Id , pet.Name, pet.IdBreed, pet.IdGender, Birth = pet.Birth.ToString("yyyy-MM-dd"), pet.IdOwner });
                }
            }
        }

        public Model.Customer SearchCustomer(string ownerName)
        {
            //obtenemos datos de bbdd
            //      Owner= OwnerRepository.Get
            //      Pet = PetRepository.Get
            //      Appointment = AppointmentRepository.Get

            //conversion de tipos (de entidades a modelo)            
            //      Customer.Human
            //              .Animal
            //              .LastAppointments

            return null;
        }

        public object SearchCustomer(int chipPet)
        {
            return null;
        }

        public object SearchCustomer(int numberNIF, char character)
        {
            return null;
        }

        public object SearchCustomerByPet(string petName)
        {
            return null;
        }
    }
}






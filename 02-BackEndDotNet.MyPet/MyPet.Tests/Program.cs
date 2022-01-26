using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace MyPet.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mysql = new MySqlConnection();
            DataAccess.ClinicRespository repoClinic = new DataAccess.ClinicRespository(mysql);

            var clinica = repoClinic.Get(new Guid("140fc325-7e9d-11ec-b4d8-025041000001"));

        }
    }
}

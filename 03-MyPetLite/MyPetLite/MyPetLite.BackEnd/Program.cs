using System;

namespace MyPetLite.BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Services.CustomerService customerService = new Services.CustomerService();
            customerService.CreateCustomer(new Model.Customer());

            Console.WriteLine("Hello World!");
        }
    }
}

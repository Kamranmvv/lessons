using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer()
            {
                Id = 1,
                Name = "Kamran",
                Surname = "Mammadov",
                Age = 20,
                Address = new Address
                {
                    Id = 1,
                    No = 9,
                    Building = "68",
                    Street = "Zulfi Haciyev",
                    City = "Sumqayit",
                    Country = "Azerbaycan"
                }
            }
                );
            customers.ForEach(i =>
            {
                Console.WriteLine($"ID: {i.Id}");
                Console.WriteLine($"Name: {i.Name}");
                Console.WriteLine($"Surname: {i.Surname}");
                Console.WriteLine($"Age: {i.Age}");
                Console.WriteLine("Address Info:");
                Console.WriteLine($"ID: {i.Address.Id}");
                Console.WriteLine($"No: {i.Address.No}");
                Console.WriteLine($"Building: {i.Address.Building}");
                Console.WriteLine($"Street: {i.Address.Street}");
                Console.WriteLine($"City: {i.Address.City}");
                Console.WriteLine($"Country: {i.Address.Country}");
                Console.WriteLine();
            });


            Console.ReadLine();
        }
    }
}

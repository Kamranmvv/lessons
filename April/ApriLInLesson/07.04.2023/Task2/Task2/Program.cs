using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            List<Customer> customers = new List<Customer>();
            
            for (int i = 0; i < x; i++)
            {
                Customer customer = new Customer();
                customer.Id = i+1;
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Email = FakeData.NetworkData.GetEmail(customer.Name, customer.Surname);
                customer.Country = FakeData.PlaceData.GetCountry();
                customer.City = FakeData.PlaceData.GetCity();

                customers.Add(customer);
            }
            foreach (var item in customers)
            {
                Console.WriteLine("Id: {0}\n\rName: {1}\n\rSurname: {2}\n\rEmail: {3}\n\rCountry: {4}\n\rCity: {5}\n\n", item.Id, item.Name, item.Surname, item.Email, item.Country, item.City);
            }
            Console.ReadLine();
        }
    }
}

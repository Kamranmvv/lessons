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
                Name = "Nihad",
                Surname = "Adigozelov",
                Age = 20,
                No = 97,
                Building = "13A",
                Street = "Sulh",
                City = "Sumqayit",
                Country = "Azerbaycan"
            });
            customers.Add(new Customer()
            {
                Id = 2,
                Name = "Kamran",
                Surname = "Mammadov",
                Age = 21,
                No = 9,
                Building = "68",
                Street = "Zulfi Haciyev",
                City = "Sumqayit",
                Country = "Azerbaycan"
});
            Customer customer = new Customer();
            customer.ForEach(customers);



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DataSource
    {
        List<Customer> Customers = new List<Customer>();

        public DataSource ()
        {
            
            for (int i = 0; i < 10000; i++)
            {
                int id = i;
                string name = FakeData.NameData.GetFirstName();
                string surname = FakeData.NameData.GetSurname();
                Random random = new Random();
                int age = random.Next(0, 100);
                bool isActive;
                int x = random.Next(1, 3);
                if (x==1)
                {
                    isActive = true;
                }
                else
                {
                    isActive = false;
                }
                Customer customer = new Customer(
                    id,
                    name,
                    surname,
                    age,
                    isActive);
                Customers.Add(customer);
                
            }
        }
        public List<Customer> TakePersonsForFirstLetter(char a)
        {
            return Customers.Where(m => m.Name.StartsWith(a.ToString())).ToList();
        }
        public List<Customer> IsActive(string x)
        {
            if (x=="1")
            {
                return Customers.Where(m => m.IsActive.ToString() == "true").ToList();
            }
            else
            {
               return Customers.Where(m => m.IsActive.ToString() == "false").ToList();
            }
            

        }
    }
}

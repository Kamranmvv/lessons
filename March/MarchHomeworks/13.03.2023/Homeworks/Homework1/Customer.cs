using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
   public class Customer : Address
    {
        
        
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

       
        public void ForEach (List<Customer> customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3} \r\nNo: {4} \r\nBuilding: {5} \r\nStreet: {6} \r\nCity: {7} \r\nCountry: {8} ",
                    item.Id,
                    item.Name,
                    item.Surname,
                    item.Age,
                    item.No,
                    item.Building,
                    item.Street,
                    item.City,
                    item.Country);

            }
        }

        
    }
}

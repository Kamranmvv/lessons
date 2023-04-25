using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }

        public Customer(int id , string name , string surname , int age, bool isActive)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            IsActive = isActive;
        }
    }
}

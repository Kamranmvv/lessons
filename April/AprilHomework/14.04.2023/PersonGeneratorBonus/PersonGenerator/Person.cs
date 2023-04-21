using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGenerator
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public int Age { get; set; }

        public Person(string name , string surname, string email, string country , int age)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Country = country;
            Age = age;
        }       
      
    }
}

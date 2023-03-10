using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID: {Id} \nName: {Name} \nSurname: {SurName}"); 
        }
    }
}

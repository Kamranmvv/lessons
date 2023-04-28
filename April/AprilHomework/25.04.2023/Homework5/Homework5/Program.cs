using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();

                people.Add(person);
            }
            people.ForEach(m => m.Fullname = $"{m.Name} {m.Surname}");
        }
    }
}

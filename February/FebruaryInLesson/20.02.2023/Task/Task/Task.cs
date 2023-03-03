using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task
    {
        public static void Test(string name, string surname)
        {
            int x = name.Length + surname.Length + 1;
            char[] letters = name.ToCharArray(); 
            if (x>=20)
            {
                Console.WriteLine(letters[0] + ". " + surname);
            }
            else
            {
                Console.WriteLine(name + " " + surname);
            }
        }
    }
}

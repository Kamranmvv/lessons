using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                string name = FakeData.NameData.GetFirstName();
                names.Add(name);
            }
            names.RemoveAll(m => m.Length >= 5);
        }
    }
}

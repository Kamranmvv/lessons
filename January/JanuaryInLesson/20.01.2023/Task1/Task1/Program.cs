using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = true;
            char second = 'A';
            byte third = 5;
            string fourth = "Salam";
            long fifth = 999999999999999999;

            string x = fifth.ToString();
            int y = x.Length;


            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(y);



            Console.ReadLine();
        }
    }
}

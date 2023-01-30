using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = null;
            while (true)
            {
                exit = Console.ReadLine().ToLower();
                if (exit == "exit")
                    break;

            }
        }
    }
}

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
            /*
                   Homework 4: 
         İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. bool, string, short, long, int, char, datetime.
            */

            Console.Write("Bool deyer daxil edin: ");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.Write("String deyer daxil edin: ");
            string s = Console.ReadLine();
            Console.Write("Short deyer daxil edin: ");
            short sh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Long deyer daxil edin: ");
            long l = Convert.ToInt64(Console.ReadLine());
            Console.Write("Int deyer daxil edin: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Char deyer daxil edin: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write("Datetime deyer daxil edin: ");
            DateTime dt = Convert.ToDateTime(Console.ReadLine());






            Console.ReadLine();


        }
    }
}

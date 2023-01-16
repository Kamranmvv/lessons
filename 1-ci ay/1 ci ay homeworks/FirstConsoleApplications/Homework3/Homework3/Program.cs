using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Homework 3:
             Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 10 - cu şəhərin adını daxil edəndən sonra bu dəfə alt-alta yox vergüllə ayırıb yazın.
             Məsələn: Baki, Gence, Sumqayit

            */
            string city1, city2, city3, city4, city5, city6, city7, city8, city9, city10;
            Console.WriteLine("Enter ten cities: ");

            #region Readline
            city1 = Console.ReadLine();
            city2 = Console.ReadLine();
            city3 = Console.ReadLine();
            city4 = Console.ReadLine();
            city5 = Console.ReadLine();
            city6 = Console.ReadLine();
            city7 = Console.ReadLine();
            city8 = Console.ReadLine();
            city9 = Console.ReadLine();
            city10 = Console.ReadLine();

            #endregion


            #region writeline
            Console.WriteLine(city1 + ", " + city2 + ", " + city3 + ", " + city4 + ", " + city5 + ", " + city6 + ", " + city7 + ", " + city8 + ", " + city9 + ", " + city10);
            #endregion
            Console.ReadLine();
        }
    }
}

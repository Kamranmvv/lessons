using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 2:
              İstifadəçidən 10 ədəd şəhər adı daxil etməsini istəyin. İstifadəçi 10 - cu şəhər adını daxil etdikdən sonra sıra ilə şəhər adlarını alt-alta ekrana yazdırın.
              Məsələn:
             Bakı
             Gəncə
              Sumqayıt
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
            Console.WriteLine(city1);
            Console.WriteLine(city2);
            Console.WriteLine(city3);
            Console.WriteLine(city4);
            Console.WriteLine(city5);
            Console.WriteLine(city6);
            Console.WriteLine(city7);
            Console.WriteLine(city8);
            Console.WriteLine(city9);
            Console.WriteLine(city10);
            #endregion
            Console.ReadLine();
            
        }
    }
}

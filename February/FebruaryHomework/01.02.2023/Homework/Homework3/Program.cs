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
            /* Homework 3:
                Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. 
                Əlavə olaraqda bütün rəqəmlərin toplamını ekrana yazdırın.*/

            int[] numberArr = new int[100];
            Random randomNumbers = new Random();
            int total = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = randomNumbers.Next(1,9);

                total = total + numberArr[i];
            }
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}

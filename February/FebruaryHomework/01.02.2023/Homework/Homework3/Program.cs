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
            int x = 0;
            int y = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = randomNumbers.Next(1,10000);
                
                

                total = total + numberArr[i];
            }
            x= numberArr.Max();
            y= numberArr.Min();
            Console.WriteLine(total);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}

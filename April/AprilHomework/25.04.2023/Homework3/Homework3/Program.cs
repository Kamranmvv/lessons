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
            int[] numberArray = new int[1000];
            int number = 0;
            for (int i = 0; i < 1000; i++)
            {
                //Random random = new Random();
                //int number = random.Next(1, 1000);
                numberArray[i] = number+i;
            }
           
            var queryEven = numberArray.Where(m => IsEven(m));
            foreach (var item in queryEven)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================");
            Console.WriteLine("======================================");

            var queryOddBetween = numberArray.Where(m => IsOdd(m) && IsBetween(m));

            foreach (var item in queryOddBetween)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        delegate bool IsTrue(int number);
        static bool IsEven(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsOdd(int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsBetween(int number)
        {
            if (number > 400 && number <= 550)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}

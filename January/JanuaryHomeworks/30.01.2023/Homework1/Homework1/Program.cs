using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər, daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.
             */
            int total = 0;


            Console.WriteLine("Include Number");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number >= 0)
            {
                total = total+number;

                Console.WriteLine("Include Number");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}

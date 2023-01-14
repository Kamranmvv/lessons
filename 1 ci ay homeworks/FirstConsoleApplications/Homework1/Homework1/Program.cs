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
            /*Homework 1:
             İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.
             */
            string name, surname, city;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter the city where you live: ");
            city = Console.ReadLine();
            Console.WriteLine(name + " " + surname + " " + city);
            Console.ReadLine();


        }
    }
}

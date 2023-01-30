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
            /* Homework 4: İstifadəçidən bir rəqəm alın. While döngüsüylə istifadəçinin daxil etdiyi rəqəmdən 0-a doğru geriyə sayın.*/
            Console.WriteLine("Include number:");

            string numberStr = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(numberStr, out number);
            while (!isNumber)
            {
                Console.WriteLine("Please check again, maybe you can't include number!");
                numberStr = Console.ReadLine();
                isNumber = int.TryParse(numberStr, out number);
            }
            while (number > 0)
            {
                number--;
                Console.WriteLine(number);
            }




            Console.ReadLine();
        }
    }
}

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
            /* Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın 
              Nəticə: 5 + 5 + 10 = 20. Bunuçıxma, vurma və bölmə üçün də edin.

            */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("3 dənə rəqəm daxil edin: ");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            double addition, subtraction, multiplication, division;
            addition = a + b + c;
            subtraction = a - b - c;
            multiplication = a * b * c;
            division = a / b / c;

            Console.WriteLine("Nəticə: " + "Vurma = " + multiplication + " Bölmə = " + division + " Toplama = " + addition + " Çıxma = " + subtraction);



            Console.ReadLine();
        }
    }
}

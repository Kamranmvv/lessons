using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatora xos geldiniz!!!");

            Console.WriteLine("Etmek istediyiniz emelliyyati secin: ");
            Console.WriteLine("1.Toplama");
            Console.WriteLine("2.Cixma");
            Console.WriteLine("3.Vurma");
            Console.WriteLine("4.Bolme");
            string calcValueStr = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Deyer daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int calcValue = 0;
            bool isNumber = int.TryParse(calcValueStr, out calcValue);
            if (!isNumber)
            {
                Console.WriteLine("Reqem daxil ele!");
            }
            else if(calcValue<1 && calcValue>4)
            {
                Console.WriteLine("Error!!!");
            }
            if (calcValue == 1)
            {
                Console.WriteLine(a + b);
            }
            else if (calcValue == 2)
            {
                Console.WriteLine(a - b);
            }
            else if (calcValue == 3)
            {
                Console.WriteLine(a * b);
            }
            else if (calcValue == 4)
            {
                if (b != 0)
                    Console.WriteLine(a / b);
                else
                    Console.WriteLine("Error!!!!!!!!!");
            }

            Console.ReadLine();

        }
    }
}

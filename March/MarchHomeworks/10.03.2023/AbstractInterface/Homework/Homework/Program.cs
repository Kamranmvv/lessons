using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 1:
               Bu gün ev tapşırığınız abstract, interface, virtual method'ları araşdırmaqdır.
               Araşdırandan sonra da, gələn dərsə qədər bir nümunə hazırlamağa çalışın. Bu bir kiçik kitabxana app'ı,
               calculator və ya hər hansısa kiçik bir task ola bilər. Generic collection'ları falan keçəndən sonra
               kiçik app'lar yazanda bunları praktika edəndə daha rahat başa düşəcəksiz çünkü hal-hazırda bunları
               real tədbiq etməyə çalışsaz hələ bilmədiyiniz nə qədər mövzu əksiyi var.
            */
            //var a = "5 * 3 + 9 / 4";
            //var b = "5 + 3 / 2";
            //var c = "(5 + 3 / 2) * 10";
            Begin:
            Menu menu = new Menu();
            Calculator calculator = new Calculator();
            string x = Console.ReadLine();

            bool runCalculator;
            if (x=="*" || x == "/" || x == "+" || x == "-")
            {
                runCalculator = true;
            }
            else
            {
                Console.Clear();
                goto Begin;

            }

            Console.Write("Birinci ededi daxil edin:");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin:");
            double num2 = int.Parse(Console.ReadLine());



            switch (x)
            {
                case "*":
                    calculator.Multiplication(num1 , num2);
                    calculator.Result();
                    Console.ReadLine();
                    Console.Clear();
                    goto Begin;
                case "/":
                    calculator.Division(num1, num2);
                    calculator.Result();
                    Console.ReadLine();
                    Console.Clear();
                    goto Begin;
                case "+":
                    calculator.Addition(num1, num2);
                    calculator.Result();
                    Console.ReadLine();
                    Console.Clear();
                    goto Begin;
                case "-":
                    calculator.Subtraction(num1, num2);
                    calculator.Result();
                    Console.ReadLine();
                    Console.Clear();
                    goto Begin;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}

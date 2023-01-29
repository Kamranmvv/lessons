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
            /*Homework 2:
            Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
            və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
            istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
            */

            Console.WriteLine("-----------------------------The Best CalculatorApp-----------------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            string calcValueStr = Console.ReadLine();
            int calcValue = 0;
            bool isNumber = int.TryParse(calcValueStr, out calcValue);
            if (!isNumber)
            {
                Console.WriteLine("Include number!");
            }
            else if (calcValue < 0 || calcValue > 4)
            {
                Console.WriteLine("Something went wrong!");
            }


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

           
             
            {
                switch (calcValue)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        goto default;

                    case 2:
                        Console.WriteLine(a - b);
                        goto default;

                    case 3:
                        Console.WriteLine(a * b);
                        goto default;
                    case 4:
                        if (b != 0)
                        {
                            Console.WriteLine(a / b);
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by zero!");
                        }
                        goto default;


                    default:
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiplication");
                        Console.WriteLine("4. Division");
                        calcValueStr = Console.ReadLine();
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                        calcValue = 0;
                        isNumber = int.TryParse(calcValueStr, out calcValue);
                        if (!isNumber)
                        {
                            Console.WriteLine("Include number!");
                        }
                        else if (calcValue < 0 && calcValue > 4)
                        {
                            Console.WriteLine("Something went wrong!");
                        }
                        else
                        {
                            if (calcValue == 1)
                                goto case 1;
                            else if (calcValue == 2)
                                goto case 2;
                            else if (calcValue == 3)
                                goto case 3;
                            else if (calcValue == 4)
                                goto case 4;
                        }
                        break;


                }
            }
           

            Console.ReadLine();

        }
    }
}

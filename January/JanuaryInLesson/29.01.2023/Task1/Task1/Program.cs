using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bal = Console.ReadLine();

            int x = 0;
            bool isNumber = int.TryParse(bal, out x);
            if (isNumber == false)
            {
                Console.WriteLine("Xahis olunur reqem daxil edin");
            }
            else
            { 
                
                if (x < 0 || x > 100)
                {
                    Console.WriteLine("duzgun reqem daxil edilmeyib");
                }
                else if (x < 20)
                {
                    Console.WriteLine("Imtahandan kesildiniz");
                }

                else if (x >= 20 && x < 40)
                {
                    Console.WriteLine("Tebrikler");
                    Console.WriteLine("qenaetbexs");
                }
                else if (40 >= x && x < 60)
                {
                    Console.WriteLine("Kafi");
                }
                else if (60 >= x && x < 80)
                {
                    Console.WriteLine("yaxsi");
                }
                else if (x >= 80)
                {
                    Console.WriteLine("Ela");
                }


            }
            Console.ReadLine();
        }
    }
}

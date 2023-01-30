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
            int total =0;
            //1-100 edelerin cemi
            for (int i = 0; i < 100; i++)
            {
                
                total = total + i;
               
            }
            Console.WriteLine(total);
            Console.ReadLine();


            //ccutler 1-100
            total = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    total = total + i;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();


            // tekler 1-100
            total = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i%2==1)
                {
                  total = total + i;
                }
                
            }
            Console.WriteLine(total);
            Console.ReadLine();
            
        }
    }
}

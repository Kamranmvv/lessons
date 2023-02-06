using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Student
    {

       public decimal CalcAverage(decimal grade1 , decimal grade2, decimal grade3)
        {
            decimal average = (grade1 + grade2 + grade3) / 3;
            return average;
        }
       public void RateAverage(decimal average)
        {
            if (average>45)
            {
                Console.WriteLine("Imtahandan Kecdiniz!");
            }
            else
            {
                Console.WriteLine("Teessufki imtahandan kesildiniz ( ");
            }
        }
        public decimal CalcAverage(decimal grade1, decimal grade2, decimal grade3, decimal grade4)
        {
            return grade1 + grade2 + grade3 + grade4;
        }

    }
}

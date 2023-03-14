using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Calculator : Base
    {
        private double _result;


        public override void Addition(double num1, double num2)
        {
            _result = num1 + num2;
        }

        public override void Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divide Zero Error!!!");
                
            }
            else
            {
                _result = num1 / num2;
            }

        }

        public override void Multiplication(double num1, double num2)
        {
            _result = num1 * num2;
        }

        public override void Subtraction(double num1, double num2)
        {
            _result = num1 - num2;
        }

        public void Result()
        {
            Console.WriteLine("Result: " + _result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    interface ICalculatorOperations
    {
        void Addition(double num1, double num2);
        void Subtraction(double num1, double num2);
        void Multiplication(double num1, double num2);
        void Division(double num1, double num2);
    }
}

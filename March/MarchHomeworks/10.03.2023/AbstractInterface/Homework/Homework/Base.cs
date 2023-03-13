using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class Base : ICalculatorOperations
    {
        public abstract void Addition(double num1, double num2);


        public abstract void Division(double num1, double num2);


        public abstract void Multiplication(double num1, double num2);


        public abstract void Subtraction(double num1, double num2);

        
        
    }
}

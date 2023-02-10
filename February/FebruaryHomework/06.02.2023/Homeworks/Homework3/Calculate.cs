using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Calculate
    {
        #region Calculates
        public decimal CalculateMethod(decimal num1, decimal num2)
        {
            decimal Addition(decimal num1Local, decimal num2Local)
            {
                decimal addition = 0;
                addition = num1Local + num2Local;
                return addition;
            }
            decimal Subtraction(decimal num1Local, decimal num2Local)
            {
                decimal subtraction = 0;
                subtraction = num1Local - num2Local;
                return subtraction;
            }
            decimal Multiplication(decimal num1Local, decimal num2Local)
            {
                decimal multiplication = 0;
                multiplication = num1Local * num2Local;
                return multiplication;
            }
            decimal Division(decimal num1Local, decimal num2Local)
            {
                decimal division = 0;

                if (num2Local == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    division = num1Local / num2Local;
                }
                return division;
            }
            decimal additionPublic = Addition(num1, num2);
            decimal subtractionPublic = Subtraction(num1, num2);
            decimal multiplicationPublic = Multiplication(num1, num2);
            decimal divisionPublic = Division(num1, num2);

            return additionPublic;
        }
        public int CalculateMethod(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                int addition = 0;
                addition = num1Local + num2Local;
                return addition;
            }
            int Subtraction(int num1Local, int num2Local)
            {
                int subtraction = 0;
                subtraction = num1Local - num2Local;
                return subtraction;
            }
            int Multiplication(int num1Local, int num2Local)
            {
                int multiplication = 0;
                multiplication = num1Local * num2Local;
                return multiplication;
            }
            int Division(int num1Local, int num2Local)
            {
                int division = 0;

                if (num2Local == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    division = num1Local / num2Local;
                }
                return division;
            }
            int additionPublic = Addition(num1, num2);
            int subtractionPublic = Subtraction(num1, num2);
            int multiplicationPublic = Multiplication(num1, num2);
            int divisionPublic = Division(num1, num2);

            return additionPublic;
        }
        public decimal CalculateMethod(string num1, string num2)
        {
            decimal Addition(string num1Local, string num2Local)
            {
                decimal addition = 0;
                decimal a = Convert.ToInt32(num1Local);
                decimal b = Convert.ToInt32(num2Local);
                addition = a + b;
                return addition;
            }
            decimal Subtraction(string num1Local, string num2Local)
            {
                decimal subtraction = 0;
                decimal a = Convert.ToInt32(num1Local);
                decimal b = Convert.ToInt32(num2Local);
                subtraction = a - b;
                return subtraction;
            }
            decimal Multiplication(string num1Local, string num2Local)
            {
                decimal multiplication = 0;
                decimal a = Convert.ToInt32(num1Local);
                decimal b = Convert.ToInt32(num2Local);
                multiplication = a * b;
                return multiplication;
            }
            decimal Division(string num1Local, string num2Local)
            {
                decimal division = 0;
                decimal a = Convert.ToInt32(num1Local);
                decimal b = Convert.ToInt32(num2Local);
                if (b == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    division = a / b;
                }
                return division;
            }
            decimal additionPublic = Addition(num1, num2);
            decimal subtractionPublic = Subtraction(num1, num2);
            decimal multiplicationPublic = Multiplication(num1, num2);
            decimal divisionPublic = Division(num1, num2);

            return additionPublic;
        }
        #endregion

        #region Percentage
        public decimal PercentageDN(decimal num1, decimal num2)
        {
            decimal percentage = 0;
            if (num1 == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                percentage = (num2 / num1) * 100;
            }


            return percentage;
        }
        public decimal PercentageND(decimal num1, decimal num2)
        {
            decimal percentage = 0;
            if (num2 == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                percentage = (num1 / num2) * 100;
            }
            return percentage;

        }
	#endregion 
    }
}

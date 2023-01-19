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
            /*   Homework 2
               
                 int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz.Sonra elə bir dəyişən yaratmalısınız ki, bütün bu 

                 ona dəyər olaraq mənimsədə biləsiniz.*/


            string nameSurname = "Kamran Mammadov ";
            string text1 = " yaşında ";
            string text2 = " gencdir? ";
            string result = "Netice:";

            long age = 21;
            bool f = false;
            char one = '1';
            string longAge = age.ToString();
            string boolFalse = f.ToString();
            string charOne = one.ToString();
            string x = nameSurname + longAge + text1 + charOne + text2 + result + boolFalse;
            Console.Write(x);




            Console.ReadLine();

        }
    }
}

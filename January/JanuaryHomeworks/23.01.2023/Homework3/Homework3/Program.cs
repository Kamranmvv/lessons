using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 3:
             İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız. Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz. Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.

            
            */
            string ageS, salaryS, heightS, weightS, friendS;
            Console.Write("Neçə yaşınız var? : ");
            ageS = Console.ReadLine();

            Console.Write("Maaşınızı daxil edin: ");
            salaryS = Console.ReadLine();

            Console.Write("Boyunuzu daxil edin: ");
            heightS = Console.ReadLine();

            Console.Write("Çəkinizi daxil edin: ");
            weightS = Console.ReadLine();

            Console.Write("Neçə dostunuz var? : ");
            friendS = Console.ReadLine();


            int age, salary, height, weight, friend;

            age = Convert.ToInt32(ageS);
            salary = Convert.ToInt32(salaryS);
            height = Convert.ToInt32(heightS);
            weight = Convert.ToInt32(weightS);
            friend = Convert.ToInt32(friendS);

           
            byte heightB = (byte)height;
            byte weightB = (byte)weight;
            byte friendB = (byte)friend;

            checked
            {
                byte ageB = (byte)age;
                byte salaryB = (byte)salary;
            }
        }
    }
}

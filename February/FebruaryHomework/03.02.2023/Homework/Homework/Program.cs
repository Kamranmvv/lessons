using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 1:
             Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
             Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
             Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
             tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
             */
            Student student = new Student();

            Console.WriteLine("------------------------------Telebe qiymet hesablama kalkulyatoru------------------------------");
            string name, surname;
            Console.Write("Adiniz daxil edin: ");
            name = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin: ");
            surname = Console.ReadLine();
            Begin:
            Console.WriteLine("Qiymetleri daxil edin: ");
            decimal grade1, grade2, grade3;
            Console.Write("Qiymet 1: ");
            grade1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qiymet 2: ");
            grade2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qiymet 3: ");
            grade3 = Convert.ToDecimal(Console.ReadLine());

            if ((grade1 > 100 || grade1 < 0) && (grade2 > 100 || grade2 < 0) && (grade3 > 100 || grade3 < 0))
            {
                Console.WriteLine("ERROR!!!");
                goto Begin;
            }

            else
            {
                decimal average = student.CalcAverage(grade1, grade2, grade3);
                
                Console.WriteLine("Ortalama: " + average);
                student.RateAverage(average);
            }
            Console.ReadLine();
        }
    }
}

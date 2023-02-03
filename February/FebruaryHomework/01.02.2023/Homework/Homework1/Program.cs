using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 1:
                Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız. Bunun üçün öncə bütün elementlərin toplamını
                tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
                bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
                Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın. Bunu həm for döngüsüylə edin həm də foreach.*/


            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Neçə ədəd daxil etmək istəyirsiniz?");

            int numberCount = 0;
            string numberCountStr = Console.ReadLine();
            bool isInt = int.TryParse(numberCountStr, out numberCount);


            int total = 0;
            double average = 0;
            while (isInt == false)
            {
                Console.WriteLine("Eded daxil edin!");
                numberCountStr = Console.ReadLine();
                isInt = int.TryParse(numberCountStr, out numberCount);
            }


            //for ile

            if (isInt == true)
            {
                for (int i = 0; i < numberCount; i++)
                {
                    int[] numbers = new int[numberCount];
                    Console.WriteLine((i + 1) + ". Rəqəmi daxil edin: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    total = total + numbers[i];
                    average = (double)total / (double)numberCount;
                }
            }

            //foreach ile
           
            //if (isInt == true)
            //{
            //    int[] numbers = new int[numberCount];
            //    foreach (var item in numbers)
            //    {
            //        int i = Array.IndexOf(numbers,item);
            //        Console.WriteLine((i + 1) + ". Rəqəmi daxil edin: ");
            //        numbers[i] = Convert.ToInt32(Console.ReadLine());

            //        total = total + numbers[i];
            //        average = (double)total / (double)numberCount;
            //    }
            //}






            Console.WriteLine("Ədədlərin Toplamı = " + total);
            Console.WriteLine("Ədədlərin ortalaması = " + average);
            Console.ReadLine();
        }
    }
}

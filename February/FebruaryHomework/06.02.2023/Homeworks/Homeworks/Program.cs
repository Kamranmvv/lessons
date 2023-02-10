using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək. Sonra sinif rəhbərinin adı
                 soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                 saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                 Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                 və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
                 şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.

                 */
            School school = new School();
            Console.WriteLine("Sinif adi daxil edin: ");
            string className = Console.ReadLine();
            Console.WriteLine("Sinif rehberinin adini daxil edin: ");
            string classLeader = Console.ReadLine();
            Console.WriteLine("Ilk 10 telebenin adini daxil edin: ");
            string student1 = Console.ReadLine();
            string student2 = Console.ReadLine();
            string student3 = Console.ReadLine();
            string student4 = Console.ReadLine();
            string student5 = Console.ReadLine();
            string student6 = Console.ReadLine();
            string student7 = Console.ReadLine();
            string student8 = Console.ReadLine();
            string student9 = Console.ReadLine();
            string student10 = Console.ReadLine();

            school.ClassData(className, classLeader, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);
            Console.ReadLine();

        }
    }
}

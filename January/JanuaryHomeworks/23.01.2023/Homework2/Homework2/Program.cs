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
            /*
             Homework 2:
             Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız. Bu məlumatlar ad, soyad, cins, doğum tarixi,
             yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

             İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
             Ad: Mark
             Soyad: Henry
             Cins: K və ya Q
             Doğum tarixi: 1990-10-10
             Yaşadığı ölkə: Azərbaycan
             Yaşadığı şəhər: Bakı
             Boy: 1.75
             Çəki: 26.50
             Maaş: 2500.00
             */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Xoş gördük ən sevimli istifadəçimiz");
            string name , surname, gender , birthday, country, city, height , weight , salary;
            #region İnput
            Console.Write("Adınızı daxil edin: ");
            name = Console.ReadLine();

            Console.Write("Soyadınızı daxil edin: ");
            surname = Console.ReadLine();

            Console.Write("Cinsinizi daxil edin (K ve ya Q): ");
            gender = Console.ReadLine();

            Console.Write("Ad günü tarixini daxil edin (2000-01-31): ");
            birthday = Console.ReadLine();

            Console.Write("Yaşadığınız ölkəni daxil edin: ");
            country = Console.ReadLine();

            Console.Write("Şəhərinizi daxil edin: ");
            city = Console.ReadLine();

            Console.Write("Boyunuzu daxil edin: ");
            height = Console.ReadLine();

            Console.Write("Çəkinizi daxil edin: ");
            weight = Console.ReadLine();

            Console.Write("Maaşınızı daxil edin: ");
            salary = Console.ReadLine();
            #endregion

            #region Helper

            char gender1 = Convert.ToChar(gender);

            DateTime birthday1;
            birthday1 = Convert.ToDateTime(birthday);

            double height1 = Convert.ToDouble(height); // float versem problem olar ?

            double weight1 = Convert.ToDouble(weight);

            double salary1 = Convert.ToDouble(salary);
            #endregion
            #region Output

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(gender1);
            Console.WriteLine(birthday1);
            Console.WriteLine(country);
            Console.WriteLine(city);
            Console.WriteLine(height1);
            Console.WriteLine(weight1);
            Console.WriteLine(salary1);
           
            #endregion



            Console.ReadLine();

        }
    }
}

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
            /* Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. 
          Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
             */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10;
            i1 = Convert.ToInt32(Console.ReadLine());
            i2 = Convert.ToInt32(Console.ReadLine());
            i3 = Convert.ToInt32(Console.ReadLine());
            i4 = Convert.ToInt32(Console.ReadLine());
            i5 = Convert.ToInt32(Console.ReadLine());
            i6 = Convert.ToInt32(Console.ReadLine());
            i7 = Convert.ToInt32(Console.ReadLine());
            i8 = Convert.ToInt32(Console.ReadLine());
            i9 = Convert.ToInt32(Console.ReadLine());
            i10 = Convert.ToInt32(Console.ReadLine());

            double plus = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10;
            double minus = i1 - i2 - i3 - i4 - i5 - i6 - i7 - i8 - i9 - i10;
            double multiplication = i1 * i2 * i3 * i4 * i5 * i6 * i7 * i8 * i9 * i10;
            double division = i1 / i2 / i3 / i4 / i5 / i6 / i7 / i8 / i9 / i10;

            Console.WriteLine(plus++);
            Console.WriteLine(minus++);
            Console.WriteLine(multiplication * 20);
            Console.WriteLine(division * 20);


            Console.ReadLine();

        }
    }
}

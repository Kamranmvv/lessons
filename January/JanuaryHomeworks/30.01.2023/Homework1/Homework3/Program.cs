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
            /* Homework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
                         alınmalıdır. Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi 
                         tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
                         Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir. Sadəcə 2. 3. 4. deyə artır cəhd sayı. İstifadəçi düzgün rəqəmi
                         tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir. */

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Texmin oyunu ucun en yuksek deyeri daxil edin: ");
            Random random = new Random();
            int number = Convert.ToInt32(Console.ReadLine());
            int randomNumber = random.Next(1, number);

            Console.WriteLine("Biz sizin daxil etdiyiniz reqem ile 1 arasinda rastgele bir reqem goturmusuk, Mence reqemi tapa bilmezsiz )");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int no = 1;
            while (randomNumber!=inputNumber)
            {
                no++;
                if (randomNumber < inputNumber)
                {
                    Console.WriteLine(no + ". Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin (çox yüksəkdən gedirsən biraz aşağı): ");
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                }
                else if (randomNumber>inputNumber)
                {
                    Console.WriteLine(no + ". Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin (əlivi qorxaq alışdırma, yuxarı) ");
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                }

                

                
            }
            if (randomNumber==inputNumber)
            {
                Console.WriteLine(no + ". Cəhdinizdə düzgün rəqəmi tapdınız!");
            }

          




            Console.ReadLine();
        }
    }
}

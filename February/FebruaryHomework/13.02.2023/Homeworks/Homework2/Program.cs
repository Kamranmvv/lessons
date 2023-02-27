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
            #region Homework
            /*Homework 2:
             Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.
             Məhsul(item) Class'ında olacaq property'lər:
            Marka
            Model
                 İstehsal ili
                 Km
                 Yanacaq növü
                 Sürətlər qutusu
                 Alış qiyməti
                 Satış qiyməti
                 Max endirim məbləği
                 Qiymət(private olması mütləqdir!)
                Constructor overload'ları aşağıdakı kimi olmalıdır:
                 1. marka, model
                 2. marka, model, istehsal ili
                 3. marka, model, istehsal ili, km
                 4. bütün property'lər
                Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
                satış qiymətini təyin edəcək.Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
                olmalıdır.Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
                Məsələn:
                Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
                satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max.endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
                */
            #endregion
            
            Console.Write("make: ");
            string make = Console.ReadLine();
            Console.Write("model: ");
            string model = Console.ReadLine();
            Console.Write("year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("km: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("fuel: ");
            string fuel = Console.ReadLine();
            Console.Write("GearBox: ");
            string gearBox = Console.ReadLine();
            Console.Write("Purchase Price: ");
            int purchasePrice = int.Parse(Console.ReadLine());
            Console.Write("Selling Price: ");
            int sellingPrice = int.Parse(Console.ReadLine());
            Console.Write("Max Discount: ");
            int maxDiscount = int.Parse(Console.ReadLine());
            Console.Write("price: ");
            int price = int.Parse(Console.ReadLine());

            Item item = new Item(make, model,year,km,fuel,gearBox,purchasePrice,sellingPrice,maxDiscount,price);

            item.MinPrice(sellingPrice, maxDiscount, price);

            item.AllInformation();


            Console.ReadLine();
        }
    }
}

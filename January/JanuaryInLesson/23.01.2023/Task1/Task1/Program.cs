using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            #region Giris
            Console.WriteLine("Xoş Gədiniz!");
            string name, gender;
            Console.Write("Adınızı daxil edin: ");
            name = Console.ReadLine();
            Console.Write("Sizə necə müraciət etməyimı istəyirsiniz? ");
            gender = Console.ReadLine();
            Console.Clear();
            #endregion

            #region Sorular
            string age, work, lastBook, color,car, sleepTime, watchingTV;

            Console.Write(name + " " + gender.ToLower().Trim() + " neçə yaşınız var?");
            age = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " hansı sahədə işləyirsiniz?");
            work = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " ən son nə zaman kitab oxumusunuz?");
            lastBook = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " ən sevdiyiniz rəng hansıdır?");
            color = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " avtomobil idarə edə bilirsiniz?");
            car = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " gündə neçə saat yatırsınız?");
            sleepTime = Console.ReadLine();

            Console.Write(name + " " + gender.ToLower().Trim() + " TV kanallarını izləyirsiniz?");
            watchingTV = Console.ReadLine();
            Console.Clear();
            #endregion

            #region Cevaplar
            Console.WriteLine("Ad: " + name + " " + gender.ToLower().Trim());
            Console.WriteLine("Yaş: " + age);
            Console.WriteLine("İş: " + work);
            Console.WriteLine("Kitab: " + lastBook);
            Console.WriteLine("Rəng: " + color);
            Console.WriteLine("Maşın: " + car);
            Console.WriteLine("Yuxu müddəti" + sleepTime);
            Console.WriteLine("TV: " + watchingTV);

            #endregion
            

            Console.ReadLine();




        }
    }
}

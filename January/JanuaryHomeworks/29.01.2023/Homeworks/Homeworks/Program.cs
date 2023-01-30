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
            /*
            Homework 1:
            Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
            Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
            Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın
            */
            Console.WriteLine("Login System");
            const string username = "Kamran";
            const string password = "Kamran2002";
            Console.Write("Username daxil edin: ");
            string usernameEntered = Console.ReadLine();
            Console.Write("Password daxil edin: ");
            string passwordEntered = Console.ReadLine();

            if (username == usernameEntered && password == passwordEntered)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else
            {   
                Console.Write("Username daxil edin: ");
                usernameEntered = Console.ReadLine();
                Console.Write("Password daxil edin: ");
                passwordEntered = Console.ReadLine();

                if (username == usernameEntered && password == passwordEntered)
                {
                    Console.WriteLine("Sisteme daxil olundu.");
                }
                else
                {
                    Console.Write("Username daxil edin: ");
                    usernameEntered = Console.ReadLine();
                    Console.Write("Password daxil edin: ");
                    passwordEntered = Console.ReadLine();
                    if (username == usernameEntered && password == passwordEntered)
                    {
                        Console.WriteLine("Sisteme daxil olundu.");
                    }
                    else
                    {
                        Console.WriteLine("Hesabiniz blok olundu");
                    }
                }
                }
               

            Console.ReadLine();

            }
        }
    }

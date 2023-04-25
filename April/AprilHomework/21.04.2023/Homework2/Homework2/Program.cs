using Homework2.Exceptions;
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
            /*Homework 2:
             Exception handling mövzusunu araşdırdıqdan sonra custom exceptionlar yazmağa çalışın. Hər hansısa bir 
             kiçik app düşünüb ona uyğun custom exception'lar yaza bilərsiniz.*/
            
            Console.WriteLine("Register Time");
            Console.WriteLine("Yeni Username daxil edin: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Yeni Şifrenizi daxil edin: ");
            string newSurname = Console.ReadLine();

            Console.Clear();
            Begin:
            try
            {
                
                Console.WriteLine("Login Time");
                Console.WriteLine("Usernamenizi daxil edin: ");
                string name = Console.ReadLine();
                Console.WriteLine("Şifrenizi daxil edin: ");
                string surname = Console.ReadLine();

                if (name != newName)
                {

                    
                    throw new WrongUsername();
                    
                }

                if (surname != newSurname)
                {
                    
                    throw new WrongPassword();
                }
            }
            catch (WrongUsername ex)
            {

                // Console.WriteLine(ex.Message);
                goto Begin;

            }
            catch (WrongPassword ex)
            {
                // Console.WriteLine(ex.Message);
                goto Begin;
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinməyən xəta!");
                goto Begin;


            }
            Console.Clear();
            Console.WriteLine("Giriş olundu!");

            Console.ReadLine();

        }
    }
}

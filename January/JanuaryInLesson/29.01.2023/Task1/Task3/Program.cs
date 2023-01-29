using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ay nomresi daxil edin:");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            Console.WriteLine("Olke daxil edin:");
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "Azerbaijan":
                    Console.WriteLine("Baku");
                    break;
                case "Argentina":
                    Console.WriteLine("Buenos Aires");
                    break;
                case "China":
                    Console.WriteLine("Beijing");
                    break;
                case "Canada":
                    Console.WriteLine("Ottawa");
                    break;
                case "England":
                    Console.WriteLine("London");
                    break;
                case "France":
                    Console.WriteLine("Paris");
                    break;
                case "Greece":
                    Console.WriteLine("Athens");
                    break;
                case "Japan":
                    Console.WriteLine("Tokyo");
                    break;
                case "Slovakia":
                    Console.WriteLine("Bratislava");
                    break;
                case "Ukraine":
                    Console.WriteLine("Kyiv or Kiev");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }




            Console.ReadLine();
        }
    }
}

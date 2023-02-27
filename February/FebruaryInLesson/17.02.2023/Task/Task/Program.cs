using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DocSerial:
            string documentSerial = Console.ReadLine();
            if (documentSerial.Length!=2)
            {
                Console.WriteLine("Vesiqenin seriya uzunlugu 2 herf olmalidir!");
                goto DocSerial;
            }
            else if (!documentSerial.All(c => Char.IsLetter(c)))
            {
                Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                goto DocSerial;
            }
            DocNumber:
            int documentNumber;
            string docNum = Console.ReadLine();
            bool isNumber = int.TryParse(docNum, out documentNumber);

            if (!isNumber)
            {
                Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                goto DocNumber;
            }
            else if (docNum.Length!=8)
            {
                Console.WriteLine("Vesiqenin uzunlugu 8 reqem olmalidir");
                goto DocNumber;
            }
            Document document = new Document();
            document.DocumentNumber = documentNumber;
            document.DocumentSerial = documentSerial;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 6:
               Hashtable içinə ENG - AZ olaraq data əlavə ediləcək.

                Soruşulacaq:
                Yeni element əlavə etmək istəyirsiniz? H/Y
                H : Yeni element əlavə etsin
                Y : Bütün elementləri göstərsin*/
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Yeni element əlavə etmək istəyirsiniz? H/Y");
            Hashtable dictionaryEnAz = new Hashtable();
            dictionaryEnAz.Add("view", "görünüşü");
            dictionaryEnAz.Add("develop", "inkişaf");
            dictionaryEnAz.Add("explain", "izah edin");
            dictionaryEnAz.Add("decision", "qərar");
            dictionaryEnAz.Add("strong", "güclü");
            dictionaryEnAz.Add("major", "əsas");
            dictionaryEnAz.Add("police", "polis");
            dictionaryEnAz.Add("drive", "sürmək");
            dictionaryEnAz.Add("full", "dolu");

            char yesOrNo = Convert.ToChar(Console.ReadLine().ToUpper());
            if (yesOrNo == 'H')
            {
                Console.WriteLine("ENG - AZ olaraq data əlavə edin.");
                dictionaryEnAz.Add(Console.ReadLine(), Console.ReadLine());
            }
            else if (yesOrNo == 'Y')
            {
                foreach (DictionaryEntry entry in dictionaryEnAz)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);

                }
            }
            else
                Console.WriteLine("Yanlis deyer girildi!");
            Console.ReadLine();
           
        }
    }
}

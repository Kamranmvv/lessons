using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {




            int globalAge = 0;//Value type
            string globalName = "";//Referance type
           
            {
                int localAge = 21;
                globalAge = localAge;
                string localName = "Kamran";
                globalName = localName;


            }
            {
                int otherLocalAge;
                otherLocalAge = globalAge;
                string otherLocalName = globalName;
                Console.WriteLine("Local Area: ");
                Console.WriteLine(otherLocalName);
                Console.WriteLine(otherLocalAge);
                Console.ReadLine();

            }
            Console.WriteLine("Global Area: ");
            Console.WriteLine(globalName);
            Console.WriteLine(globalAge);
            Console.ReadLine();

        }
    }
}

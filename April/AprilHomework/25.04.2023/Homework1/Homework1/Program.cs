using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAnyMethod myDelegate = Add;
            myDelegate();
            myDelegate = Edit;
            myDelegate();
            myDelegate = Delete;
            myDelegate();

            
        }
        delegate void RunAnyMethod();
        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }

    }
}

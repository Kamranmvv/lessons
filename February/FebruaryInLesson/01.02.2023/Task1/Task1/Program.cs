using System;
using System.Collections;
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
            Console.WriteLine("Sinifde nece telebe var?");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            string[] students = new string[studentCount];
            byte[] studentsAge = new byte[studentCount]; 

            for (int i = 0; i < students.Length; i++)            {                Console.WriteLine((i+1) + ". Telebenin adini daxil edin: ");                string studentName = Console.ReadLine();                students[i] = studentName;                Console.WriteLine((i+1) + ". Telebenin yasini daxil edin: ");                byte studentAge = Convert.ToByte(Console.ReadLine());                studentsAge[i] = studentAge;
            }
            Console.Clear();

            
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Ad: " + students[i]);
                Console.WriteLine("Yas: " + studentsAge[i]);


            }


            Hashtable ht = new Hashtable();






            Console.ReadLine();
        }
    }
}

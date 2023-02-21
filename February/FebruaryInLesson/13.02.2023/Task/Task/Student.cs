using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string FatherName;



        public Student(string name ,string surname ,int age , string fatherName)
        {
            if(name == "Orkhan")
            {
                Console.WriteLine("Error");
            }
            else if (age>35)
            {
                Console.WriteLine("Telebenin yasi 34 den yuxari ola bilmez");
            }
            else
            {
                Name = name;
                Surname = surname;
                Age = age;
                FatherName = fatherName;
            }
            
        }

    }
}

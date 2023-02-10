using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class School
    {
        public void ClassData(string className , string classLeader , params string [] students)
        {
            string classNameData = className;
            string classLeaderData = classLeader;
            string [] studentsDatas = new string[10];
            students.CopyTo(studentsDatas, 0);
            Console.Clear();
            Console.WriteLine("--------------------------------------Sinif melumatlari--------------------------------------");
            Console.WriteLine(classNameData);
            Console.WriteLine(classLeaderData);
            for (int i = 0; i < studentsDatas.Length; i++)
            {
                Console.WriteLine(studentsDatas[i]);
            }
        }
    }
}

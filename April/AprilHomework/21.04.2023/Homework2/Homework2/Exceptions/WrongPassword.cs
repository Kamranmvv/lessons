using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Exceptions
{
    public class WrongPassword : Exception
    {
        public WrongPassword()
        {
            Console.WriteLine("Şifre yanlışdır!");
        }
    }
}

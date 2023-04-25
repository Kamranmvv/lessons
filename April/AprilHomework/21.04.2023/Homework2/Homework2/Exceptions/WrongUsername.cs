using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Exceptions
{
    public class WrongUsername : Exception
    {
        public WrongUsername()
        {
            Console.WriteLine("Username yanlışdır!");
        }
    }
}

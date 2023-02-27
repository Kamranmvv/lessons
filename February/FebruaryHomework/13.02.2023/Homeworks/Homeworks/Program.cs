using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            bool customerTrue = customer.CheckCustomerFromDb("123456");

        }
    }
}

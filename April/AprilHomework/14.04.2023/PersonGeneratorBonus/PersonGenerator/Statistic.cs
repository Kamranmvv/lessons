using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGenerator
{
    public class Statistic
    {
        public string Country { get; set; }

        public string Ages { get; set; }
        public int CountAges { get; set; }

        public Statistic(string country,string ages,int countAges)
        {
            Country = country;
            Ages = ages;
            CountAges = countAges;
        }
    }
}

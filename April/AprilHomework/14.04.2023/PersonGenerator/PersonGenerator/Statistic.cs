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
        public int CountCountry { get; set; }

        public Statistic(string country,int countCountry)
        {
            Country = country;
            CountCountry = countCountry;
        }
    }
}

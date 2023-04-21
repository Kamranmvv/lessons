using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGenerator
{
    public static class VirtualDatabase
    {
        public static BindingList<Person> Persons { get; set; } = new BindingList<Person>();
        public static BindingList<Statistic> Statistics { get; set; } = new BindingList<Statistic>();

    }

   
}

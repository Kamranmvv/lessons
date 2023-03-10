using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public sealed class Tv : Product
    {
        public bool IsSmartTv { get; set; }
        public string HasHDMI { get; set; }
        public string Resolution { get; set; }

    }
}

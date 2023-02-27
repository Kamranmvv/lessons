using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class WorkSchedule : Base
    {
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public Array RestDays { get; set; }
    }
}

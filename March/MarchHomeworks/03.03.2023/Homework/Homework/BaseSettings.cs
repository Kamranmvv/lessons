using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class BaseSettings : Base
    {
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? EditUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int DeleteDate { get; set; }
        public DateTime DeleteUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}

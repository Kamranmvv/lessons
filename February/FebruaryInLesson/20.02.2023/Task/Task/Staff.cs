using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Staff
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        private string _email;
        public string Email {
            get
            {
                return _email;
            }
            set
            {
                _email = value.ToLower()+"@gmail.com";
            }
        }
        public string Gender { get; set; }

       

    }
}

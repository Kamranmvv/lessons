using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _email;


        public string Name
        {
            set
            {
                _name = value;
                if (_name != null && _surname != null)
                {
                    _email = _name.ToLower() + "." + _surname.ToLower() + "@gmail.com";

                }
                else
                {
                    _email = null;
                }
            }
            get
            {
                return _name;
            }
        }
        public string Surname
        {
            set
            {
                _surname = value;
                if (_name != null && _surname != null)
                {
                    _email = _name.ToLower() + "." + _surname.ToLower() + "@gmail.com";

                }
                else
                {
                    _email = null;
                }
            }
            get
            {
                return _surname;
            }
        }
        


       
       
        
        
    }
}

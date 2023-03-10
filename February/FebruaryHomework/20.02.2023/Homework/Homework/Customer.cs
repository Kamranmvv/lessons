using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Customer
    {
        private string _username;
        private string _password;
        private static ArrayList List;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                
                if (CheckDublicateUsername()==true)
                {
                    Console.WriteLine("Elave etmek istediyiniz username artiq sistemde movcuddur!");
                }
            }
        }
        public string Password { get; set; }
        
        static Customer()
        {
            List = new ArrayList();
            
        }
        public ArrayList DataBase()
        {
            List.Add(Username);
            List.Add(_username);
            List.Add(_username);
            List.Add(_username);
            return List;
        }
        
        public void CheckEmptyOrNull(Customer customer)
        {
            if (customer!=null)
            {
                bool checkUsername = string.IsNullOrEmpty(Username);
                bool checkEmail = string.IsNullOrEmpty(Email);
            }
            else
                Console.WriteLine("Error!!!");
        }

        public bool CheckDublicateEmail()
        {
            List.Add(Email);
            return true;
        }





        public bool CheckDublicateUsername()
        {
            foreach (string item in List)
            {
                if (List.IndexOf(item) != List.LastIndexOf(item))
                {
                    return true;      
                }
            }
            return false;
        }


       

    }
}

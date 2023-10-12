using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//UserService dan foydalaning
//unda quyidagi methodlar bo'lsin
//- Users collection
//- Add ( emailAddress, password ) -user ni validate qilib qo'shadi
//- GetUsers - userlar kolleksiyasini qaytaradi 

namespace First_or_default_prepend_HT
{
    internal class UserService
    {
        List<User> _users = new List<User>();
        

        public UserService()
        {
            _users = new List<User>
            {
                new User("Abdura43@gmail.com", "Abdura323"),
                new User("Abdurahmon42@gmail.com", "mirzohid7707"),
                new User("Asadov_qirol34@gmail.com", "fjbfewife")
            };
        }

        public void Add(string emailAddress, string password)
        {
            var regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if(!Regex.IsMatch(emailAddress, regexPattern))
            {
                Console.WriteLine("Your entered emailAddress is invalid: ");
            }

            if(password.Length < 8) 
            {
                Console.WriteLine("Password must be at least 8 characters;");
            }

            _users.Add(new User{ Emailddress = emailAddress, Password = password });
            Console.WriteLine("Users added succesfully");
        }

        public List<User> GetUser()
        {
            return _users;
        }
    }
}

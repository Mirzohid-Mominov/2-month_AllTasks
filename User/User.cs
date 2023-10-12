using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//- User modelidan foydalaning(emailAddress, password )


namespace User_LessonTask
{
    public class User
    {
        public string EmailAdress { get; set; }
        public string Password { get; set; }

        public User(string emailAddres, string password)
        {
            EmailAdress = emailAddres;
            Password = password;
        }
    }
}

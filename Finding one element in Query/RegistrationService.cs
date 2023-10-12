using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//RegistrationService ni update qiling

//unga Login ( string emailAddress, string password ) methodini qo'shing, unda
//- user ni emailAddress va password bo'yicha topsin
//- agar topilgan userda email yoki telefon raqami verify bo'lmagan bo'lsa ekranga "Sorry, you haven't verified your email address / phone number" deb chiqsin, bo'lmasa true qaytarsin

namespace Finding_one_element_in_Query
{
    internal class RegistrationService
    {

        private List<User> _users = new List<User>();
        public bool Login(string emailAddress, string password)
        {
            var item = _users.FirstOrDefault(user => user.IsEmailVerified == emailAddress);
            if (item == null)
            {
                Console.WriteLine("Siz registratsiyadan otmagansz!!!");
                return false;
            }
            else
            {
                _users.Add(new User(emailAddress, password));
                return true;
            }

        }
    }
}

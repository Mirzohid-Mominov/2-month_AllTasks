using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//User modelidan foydalaning ( id, emailAddress, password, isAdmin )

namespace First_or_default_prepend_HT
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Emailddress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User() { }
        public User(string emailAddress, string password, bool isAdmin = false)
        {
            Id = Guid.NewGuid();
            emailAddress = emailAddress;
            Password = password;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return $"{Emailddress} {Password}, IsAdmin : {IsAdmin}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User modelidan foydalaning ( id, firstname, lastname, emailAddress, isDeleted )


namespace User_HT
{
    internal class User
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsDeleted { get; set; }
    }
}

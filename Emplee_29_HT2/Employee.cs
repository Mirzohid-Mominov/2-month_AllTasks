using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Employee modeldan foydalaning ( id, firstname, lastname )


namespace Emplee_29_HT2
{
    internal class Employee
    {
        public Employee(string firstName, string lastName, string emailAddress)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}

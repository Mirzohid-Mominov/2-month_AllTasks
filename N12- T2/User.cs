using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N12__T2
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }


        public User(string firstName, string lastName, string name)
        {
            FirstName = firstName;
            LastName = lastName;
            Name = name;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode() + Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is User user)
                return this.GetHashCode() == user.GetHashCode();
            return false;
        }









    }
}

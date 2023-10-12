using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager.Model
{
    public class Developer : User
    {
        public List<Task> Assignedtasks {  get; set; }

        public Developer(string username, string password)
            : base(username, password, (int)UserRole.Developer)
        {
            Assignedtasks = new List<Task>();
        }
    }
}

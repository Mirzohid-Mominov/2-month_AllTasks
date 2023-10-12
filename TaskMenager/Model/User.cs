using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager.Model
{
    public enum UserRole
    {  
        ProjectManager,
        Developer
    }
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }

        public User(string username, string password, int roleId)
        {
            Username = username;
            Password = password;
            RoleId = roleId;
            
        }
    }
}

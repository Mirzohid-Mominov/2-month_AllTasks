using BackendTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Files
{
    public class FileContext : IFileContext
    {
        private string _filePath = @"D:\All_Homework\User.txt";
        private List<User> _users = new List<User>();

        public User AddUser(User user)
        {
            return _users.Add(user);

        }
    }
}

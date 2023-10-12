using BackendTest.Files;
using BackendTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Services
{
    public class UserService : IUserService
    {
        private readonly IFileContext _fileContext;

        public UserService(IFileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public User AddUser(User user)
        {
            return _fileContext.AddUser(user);
        }
    }
}

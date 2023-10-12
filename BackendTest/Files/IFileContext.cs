using BackendTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Files
{
    public interface IFileContext
    {
        public User AddUser(User user);
    }
}

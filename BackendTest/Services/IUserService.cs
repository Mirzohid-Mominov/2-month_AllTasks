using BackendTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Services
{
    public interface IUserService
    {
        User AddUser(User user);
    }
}

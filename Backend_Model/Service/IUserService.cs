using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend_Model.Model;

namespace Backend_Model.Service
{
    interface IUserService
    {
        void Add(User user);
        User Get(User user);
        List<User> GetAll();
        void Update(User user);
        void Delete(int id);
    }
}

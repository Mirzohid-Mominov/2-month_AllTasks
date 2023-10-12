using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

//IUserService dan foydalaning
//unda quyidagi methodlar bo'lsin

//- Get ( pageSize, pageToken ) -userlarni pagination bian qaytarsin
//- Search ( searchKeyword, pageSize, pageToken ) -userlar ni kalit so'z bo'yicha qidirib pagination bilan qaytarsin
//- Filter ( userFilterModel ) -userlarni filter qilib pagination bilan qaytarsin
//- Add ( firstname, lastname, emailAddress ) -email address unique bo'lsa user ni qo'shsin va qaytarsin, bo'lmasa exception
//- Update ( user ) -userlar ichidan berilgan user borligini topib, update qilsin va qaytarsin, bo'lmasa exception
//- Delete ( id ) -userlar ichidan berilgan id bo'yicha user borligini topib IsDeleted true qilsin, bo'lmasa exception


namespace User_HT
{
    internal class UserService : IUserService
    {
        public List<User> _users = new List<User>();

        // - Get(pageSize, pageToken ) -userlarni pagination bian qaytarsin
        public List<User> Get(int pageSize, int pageToken)
        {
            if (pageSize <= 0)
                throw new ArgumentException("pageSize must be greater than zero.");

            if (pageToken <= 0)
                throw new ArgumentException("pageToken must be greater than zero.");

            var users = _users.Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
            return users;
        }

        //- Search ( searchKeyword, pageSize, pageToken ) -userlar ni kalit so'z bo'yicha qidirib pagination bilan qaytarsin
        public List<User> Search(string searchKeyword, int pageSize, int pageToken)
        {
            return _users.Where
                (
                user => searchKeyword.ToLower().Contains(user.FirstName.ToLower())
                || searchKeyword.ToLower().Contains(user.LastName.ToLower())
                || searchKeyword.ToLower().Contains(user.EmailAddress.ToLower())
                 ).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();

        }

        //- Filter ( userFilterModel ) -userlarni filter qilib pagination bilan qaytarsin
        public List<User> Filter(UserFilterModel userFilterModel)
        {
            var userfilter = _users.Where(x => !x.IsDeleted);
            var filteredusers = userfilter.Where(x =>
            {
                return (userFilterModel.FirstName is null || userFilterModel.FirstName == x.FirstName) &&
                (userFilterModel.LastName is null || userFilterModel.LastName == x.LastName);
            }).ToList();
            return filteredusers;
        }

        //- Add ( firstname, lastname, emailAddress ) -email address unique bo'lsa user ni qo'shsin va qaytarsin, bo'lmasa exception
        public User Add(string firstname, string lastname, string emailAddress)
        {
            if (_users.Any(emailuser => emailuser.EmailAddress == emailAddress))
            {
                throw new Exception("User with the same email address already exists.");
            }

            var newUser = new User()
            {
                FirstName = firstname,
                LastName = lastname,
                EmailAddress = emailAddress
            };

            _users.Add(newUser);
            return newUser;
        }

        //-userlar ichidan berilgan user borligini topib, update qilsin va qaytarsin, bo'lmasa exception
        public List<User> Update(User user)
        {
            var userIndex = _users.FindIndex(u => u.Id == user.Id);
            if (userIndex == -1)
                throw new ArgumentException("User not found.");

            _users[userIndex] = user;
            return _users;
        }

        //- Delete ( id ) -userlar ichidan berilgan id bo'yicha user borligini topib IsDeleted true qilsin, bo'lmasa exception
        public bool Delete(Guid id)
        {
            var userToDelete = _users.FirstOrDefault(user => user.Id == id);

            if (userToDelete == null)
            {
                throw new ArgumentException("User not found.");
            }

            userToDelete.IsDeleted = true;
            return true;
        }
    }
}

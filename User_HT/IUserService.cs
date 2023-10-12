using System;
using System.Collections.Generic;
using System.Linq;
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
    interface IUserService
    {
        public List<User> Get(int pageSize, int pageToken);
        public List<User> Search(string searchKeyword, int pageSize, int pageToken);
        public List<User> Filter(UserFilterModel userFilterModel);
        public User Add(string firstname, string lastname, string emailAddress);
        public List<User> Update(User user);
        public bool Delete(Guid id);
    }
}

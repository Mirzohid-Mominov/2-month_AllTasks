using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -RegistrationServicedan foydalaning
//unda Users kolleksiyasi bo'lsin

//unda quyidagi methodlar bo'lsin
//- Register( emailAddress, password ) -agar email address mavjud bo'lsa ekranga "Bu email address allaqachon bor" degan message chiqsin bo'lmasa collection ga qo'shsin


//- dasturda RegistrationService dan object yarating
//- unga 3 unique user qo'shing
//- foydalanuvchidan email address va passwordni so'rab Register methodi orqali qo'shing


namespace User_LessonTask
{
    internal class RegistrationService
    {
        private List<User> _users = new();    

        public bool Register(string emailAddress,  string password)
        {
            if (_users.Any(user => user.EmailAdress == emailAddress))
            {
                Console.WriteLine("Allready have!!!");
                return false;
            }

            else
            {
                _users.Add(new User(emailAddress, password));
                return true;
            }
        }
    }
}

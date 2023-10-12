using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//RegistrationService dan foydalaning
//unda quyidagi methodlar bo'lsin 

//- Register ( firstName, lastName, emailAddress, password )
//-UserService orqali userni UserCredentialsService orqali credentialni qo'shsin, hammasi muvaffaqqiyatli bo'lsa true, bo'lmasa false qaytarsin


namespace User_HT
{
    internal class RegistrationService
    {
        public UserService userService;
        public UserCredentialsService userCredentials;

        public RegistrationService(UserService user, UserCredentialsService userCredentials)
        {
            this.userService = user;
            this.userCredentials = userCredentials;
        }

        public bool Register(string firstName, string lastName, string emailAddress, string password )
        {
            try
            {
                var user = userService.Add(firstName, lastName, emailAddress);
                userCredentials.Add(user.Id, password);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

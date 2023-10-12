using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//UserCredentialsService da IUserCredentialsService ni implement qiling
//IUserCredentialsService dan foydalaning
//unda quyidagi methodlar bo'lsin 

//- Add ( userId, password ) -password ni strong ekanligini regex bilan tekshirsin ( 8 <= simvol, 1 <= katta harf, 1 <= son ), valid bo'lsa qo'shsin va credential ni qaytarsin bo'lmasa exception
//- GetByUserId ( userId ) -user Id bo'yicha credential ni topib qaytarsin, bo'lmasa null


namespace User_HT
{
    internal class UserCredentialsService : IUserCredentialsService
    {
        private List<UserCredential> _credentialList = new List<UserCredential>();
        public UserCredentialsService() => _credentialList = new List<UserCredential>();


        //- Add ( userId, password ) -password ni strong ekanligini regex bilan tekshirsin ( 8 <= simvol, 1 <= katta harf, 1 <= son ), valid bo'lsa qo'shsin va credential ni qaytarsin bo'lmasa exception
        public UserCredential Add(Guid userId, string password)
        {
            Regex passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*\d).{8,}$");
           
            if (passwordRegex.IsMatch(password))
            {
                var  userCredential = new UserCredential(password, userId);
                _credentialList.Add(userCredential);
                return userCredential;
                
            }
            throw new Exception("Password is not valid or string");
        }
        public UserCredential GetByUserId(Guid userId)
        {
            return _credentialList.Any(c => c.Userid == userId)
            ? _credentialList.Find(c => c.Userid == userId)
            : null;
        }
    }
}

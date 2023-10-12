using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IUserCredentialsService dan foydalaning
//unda quyidagi methodlar bo'lsin 

//- Add ( userId, password ) -password ni strong ekanligini regex bilan tekshirsin ( 8 <= simvol, 1 <= katta harf, 1 <= son ), valid bo'lsa qo'shsin va credential ni qaytarsin bo'lmasa exception
//- GetByUserId ( userId ) -user Id bo'yicha credential ni topib qaytarsin, bo'lmasa null


namespace User_HT
{
    interface IUserCredentialsService
    {
        public UserCredential Add(Guid userId,  string password);
        public UserCredential GetByUserId(Guid userId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User modelini update qiling
//unga quyidagi propertylar qo'shing

//- IsEmailVerified
//- IsPhoneVerified

namespace Finding_one_element_in_Query
{
    internal class User
    {
        public string IsEmailVerified { get; set; }
        public string IsPhoneVerified { get; set; }

        public User(string isEmailVerified, string isPhoneVerified)
        {
            IsEmailVerified = isEmailVerified;
            IsPhoneVerified = isPhoneVerified;
        }
    }
}

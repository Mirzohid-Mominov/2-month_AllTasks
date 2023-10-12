using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UserFilterModel dan foydalaning ( firstname?, lastname? ) u FilterModel dan inheritance olgan bo'lsin

namespace User_HT
{
    internal class UserFilterModel : FilterModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}

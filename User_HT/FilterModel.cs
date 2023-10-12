using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FilterModel abstrakt modeldan foydalaning ( pageSize, pageToken )

namespace User_HT
{
    public  abstract class FilterModel
    {
        public int PageSize { get; set; }
        public int PageToken { get; set; }
    }
}

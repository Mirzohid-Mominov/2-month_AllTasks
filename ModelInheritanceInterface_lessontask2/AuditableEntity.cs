using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- AuditableEntity abstract modelidan foydalaning(createdDate, modifiedDate )

namespace ModelInheritanceInterface_lessontask2
{
    abstract class AuditableEntity
    {
        
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}

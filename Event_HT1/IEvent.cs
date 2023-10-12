using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IEvent interfeysidan foydalaning ( id, name, date ) 
//Event modelidan foydalaning - IEvent interfeysini implement qilgan bo'lsin

namespace Event_HT1
{
    internal interface IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

//Event modelidan foydalaning - IEvent interfeysini implement qilgan bo'lsin


namespace Event_HT1
{
    internal class Event : IEvent
    {
        public Event(string name, DateTime date)
        {
            Id = new Guid();
            Name = name;
            Date = date;
        }

        public Guid Id { get; set; }
        public string Name { get ; set; }
        public DateTime Date { get ; set; }

        public override string ToString()
        {
            return $"{Name} {Date}";
        }
    }
}

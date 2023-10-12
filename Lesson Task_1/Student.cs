using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task_1
{
    public class Student<TID, TGrade>
    {
        public TID ID { get; set; }
        public TGrade Trade { get; set;}
        public string Name { get; }

        public Student(TID studentId, TGrade trade, string name)
        {
            Name = name;
            ID = studentId;
            Trade = trade;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nStudent Id : {ID}\nTrade : {Trade}";
        }
    }
}

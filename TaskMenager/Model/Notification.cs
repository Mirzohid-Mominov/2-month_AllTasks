using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TaskMenager.Model
{
    public class Notification
    {
        public User Pesipient { get; set; }
        public string Message { get; set; }
        public DateTime TimeSpan { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-Review modelidan foydalaning(id, star, message ) -IReview ni implement qilsin


namespace First_Or_Default_HT
{
    internal class Review : IReview
    {
        public Review( string message, int star)
        {
           
            Message = message;
            Star = star;
        }

        public Guid Id { get ; set ; }
        public string Message { get ; set ; }
        public int Star { get ; set ; }

    }
}

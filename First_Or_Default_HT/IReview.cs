using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- IReview interfeysdan foydalaning ( id, star, message )

namespace First_Or_Default_HT
{
    public interface IReview
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public int Star { get; set; }
    }
}

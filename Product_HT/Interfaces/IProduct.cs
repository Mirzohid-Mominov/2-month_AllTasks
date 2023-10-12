using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IProduct interfeysdan foydalaning ( id, name, description, isOrdered, price )


namespace Product_HT.Interfaces
{
    interface IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public double Price { get; set; }

    }
}

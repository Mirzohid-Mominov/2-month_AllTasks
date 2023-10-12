using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Product modelidan foydalaning 
//unda quyidagi propertylar bo'lsin 
//- Name
//- Price

namespace OnlineMarket_HT
{
    internal class Product
    {
        public string Name { get; }
        public double Price { get; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}

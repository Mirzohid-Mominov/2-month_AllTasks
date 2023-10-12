using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Product modelidan foydalaning ( id, name, description )
//-bunda id init-only bo'lsin
//- name va description read-only bo'lsin ( private set )
//- name va description getter methodi ichida name va description ni validate qiling ( regex dan foydalanish ixtiyoriy, is null or white space yetarli )
//-parameterized constructorda name va description bo'lsin
//- copy constructor orqali Product ni copy qiladigan qiling

namespace Property_constructor_Types
{
    internal class Product
    {
        public Guid Id { get; init; }
        private readonly string _name;
        public string Name
        {
            get => _name;
            private set
            {
                if(string.IsNullOrWhiteSpace(_name))
                {
                    throw new ArgumentException("Name cannot be null or empty!\n");
                }
                Name = value;
            }
        }

        private readonly string _description;
        public string Description
        {
            get => _description;
            private set
            {
                if(string.IsNullOrWhiteSpace(_description))
                {
                    throw new ArgumentException("Description cannot be null or empty!\n");
                }
                Description = value;
            }
        }

        public Product(Product other)
        {
            Id = new Guid();
            _name = other._name;
            _description = other._description;
        }

        public Product(string name, string description)
        {
            Id = new Guid();
            Name = name;
            Description = description;
        }
    }
}

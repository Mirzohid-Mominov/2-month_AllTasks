using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Product_HT.Interfaces;

//Laptop modelidan foydalaing - ( cpuBrand, cpuModel ) -IProduct implementatsiyasi


namespace Product_HT
{
    internal class Laptop : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public double Price { get; set; }
        public string CpuBrand { get; set; }
        public string CpuModel { get; set; }

        public Laptop(string name, string description, bool isOrdered, double price, string cpuBrand, string cpuModel)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Description = description;
            this.IsOrdered = isOrdered;
            this.Price = price;
            this.CpuBrand = cpuBrand;
            this.CpuModel = cpuModel;
        }

        public Laptop(Laptop laptop)
        {
            this.Id = laptop.Id;
            this.Name = laptop.Name;
            this.Description = laptop.Description;
            this.IsOrdered = laptop.IsOrdered;
            this.Price = laptop.Price;
            this.CpuBrand = laptop.CpuBrand;
            this.CpuModel = laptop.CpuModel;
        }
    }
}


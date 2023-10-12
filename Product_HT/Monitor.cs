using Product_HT.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Monitor modelidan foydalaning - ( displaySize, refreshRate ) -IProduct implementatsiyasi

namespace Product_HT
{
    public class Monitor : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOrdered { get; set; }
        public double Price { get; set; }
        public double DisplaySize { get; set; }
        public int RefreshRate { get; set; }

        public Monitor(string name, string description, bool isOrdered, double price, double displaySize, int refreshRate)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Description = description;
            this.IsOrdered = isOrdered;
            this.Price = price;
            this.DisplaySize = displaySize;
            this.RefreshRate = refreshRate;
        }

        public Monitor(Monitor monitor)
        {
            this.Id = monitor.Id;
            this.Name = monitor.Name;
            this.Description = monitor.Description;
            this.IsOrdered = monitor.IsOrdered;
            this.Price = monitor.Price;
            this.DisplaySize = monitor.DisplaySize;
            this.RefreshRate = monitor.RefreshRate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12___T1
{
    internal class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public Car(string name, string brand) 
        { 
            Name = name;
            Brand = brand;
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode() + Brand.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Car car)
                return this.GetHashCode() == car.GetHashCode();
            return false;
        }









    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    class Truck
    {
        private string brand;
        private int load, maximumSpeed, price;

        public Truck(string brand, int load, int maximumSpeed, int price)
        {
            this.brand = brand;
            this.load = load;
            this.maximumSpeed = maximumSpeed;
            this.price = price;
        }
        public Boolean Compare(int load, int maximumSpeed, int price)
        {
            if (this.load <= load && this.maximumSpeed <= maximumSpeed && this.price <= price)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public string toString() {
            return "Brand = " + brand + " load = " + load + " maximum speed = " + maximumSpeed + " price = " + price;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class Transport
    {
        private string name;
        private int price;
        private int benefit;

        public Transport(string name, int price,int benefit)
        {
            this.name = name;
            this.price = price;
            this.benefit = benefit;
        }
        public virtual string toString()
        {
            return " name = " + name + " price = "+ price +" benefit = "+ benefit;
        }
    }
}

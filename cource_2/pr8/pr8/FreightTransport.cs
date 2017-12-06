using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class FreightTransport : Transport
    {
        private int load;
        public FreightTransport(string name, int price, int benefit, int load) 
            : base(name, price, benefit)
        {
            this.load = load;
        }
        virtual public string toString()
        {  
            return base.toString() + " load = " + load;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class PassengerTransport:Transport
    {
        private int numOfPassenger;
        public PassengerTransport(string name, int price, int benefit,  int numOfPassenger) 
            : base(name, price, benefit)
        {
            this.numOfPassenger = numOfPassenger;  
        }
        virtual public string toString()
        {
            return base.toString() + " numOfPassenger = " + numOfPassenger;
        }
    }
}

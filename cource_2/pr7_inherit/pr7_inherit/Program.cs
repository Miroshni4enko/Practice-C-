using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketCarrier rockCar = new RocketCarrier();
            rockCar.setName("rockCar");
            Carrier carrier = new Carrier();
            carrier.setName("Carrier");

        }
    }
}

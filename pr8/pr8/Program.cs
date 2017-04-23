using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerTransport passTran = new PassengerTransport("passTran", 1000, 300, 10);
            FreightTransport freTran = new FreightTransport("freTran", 2000, 400, 1000);
            Console.WriteLine(passTran.toString());
            Console.WriteLine(freTran.toString());
            Console.ReadKey();

        }
    }
}

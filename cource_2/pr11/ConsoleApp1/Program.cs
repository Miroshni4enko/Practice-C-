using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus[] buss = new Bus[] {new Bus("Bus1", 3,100,1000), new Bus("Bus1", 3, 100, 1000), new Bus("Bus2", 20, 120, 2000), new Bus("Bus3", 10, 220, 3000) };
            for (int i = 1; i < buss.Length; i++)
            {
                if (buss[i - 1] == buss[i])
                {
                    Console.WriteLine(buss[i - 1].toString() + " == " + buss[i].toString());
                }
                else if(buss[i - 1] <= buss[i])
                {
                    Console.WriteLine(buss[i - 1].toString() + " <= " + buss[i].toString());
                }
                
            }
            Console.WriteLine("Concat" + buss[0].toString() + " + " + buss[1].toString() );
            Console.WriteLine((buss[0] + buss[1]).toString());
            Console.ReadKey();
        }
    }
}

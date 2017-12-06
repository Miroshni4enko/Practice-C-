using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    class Program
    {
        static int GetField(String textForUser)
        {
            Console.Write(textForUser);
            return Convert.ToInt32(Console.ReadLine());
        }
        static string GetFieldStr(String textForUser)
        {
            Console.Write(textForUser);
            return Console.ReadLine();
            
        }
        static Truck[] createAndFillTrucs(int numOfTrucs)
        {
            string brand;
            int load,maximumSpeed, price;
            Truck[] trucs = new Truck[numOfTrucs];
            for (int i = 0; i < numOfTrucs; i++)
            {

                brand = GetFieldStr("brand = ");
                load = GetField("load = ");
                maximumSpeed = GetField("maximumSpeed = ");
                price = GetField("price = ");
                trucs[i] = new Truck(brand,load,maximumSpeed,price);
            }
            return trucs;
        }

        static void Main(string[] args)
        {
            int load, maximumSpeed, price;
            int numOfTrucs;
            Truck[] trucs;
            numOfTrucs = GetField("Number of Trucs = ");
            trucs = createAndFillTrucs(numOfTrucs);
            Console.WriteLine("Enter need parameters");
            load = GetField("load = ");
            maximumSpeed = GetField("maximumSpeed = ");
            price = GetField("price = ");

            Console.WriteLine("Appropriate trucs");
            for (int i = 0; i < numOfTrucs; i++)
            {
                if (trucs[i].Compare(load, maximumSpeed, price))
                {
                    Console.WriteLine(trucs[i].toString());
                }
            }
            Console.ReadKey();
        }
    }
}

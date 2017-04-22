using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            string variant, forConvert;
            double x, z = 0;
            Console.WriteLine("Ent x");
            forConvert = Console.ReadLine();
            x = Convert.ToDouble(forConvert);
            Console.WriteLine("Ent variant");
            variant = Console.ReadLine();
            switch (variant) {
                case "first":
                case "FIRST":
                case "FIRST)":
                    z = Math.Pow(Math.Sin(x),2.0);
                    break;
                case "second":
                case "SECOND":
                case "SECOND)":
                    z = Math.Pow(Math.Log(x), 2.0);
                    break;
                case "third":
                case "THIRD":
                case "THIRD)":
                    double l;
                    Console.WriteLine("Ent l");
                    forConvert = Console.ReadLine();
                    l = Convert.ToDouble(forConvert);
                    z = l / Math.Cos(Math.Pow(x, 3.0));
                    break;
            }
            Console.WriteLine("z =" + z);
            Console.ReadKey();
        }
    }
}

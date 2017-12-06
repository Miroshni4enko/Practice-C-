using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Math;

namespace pr10
{
    class Program
    {
        static double func(int k, int x) {
            return Pow(1 / Atan(k * x), 1.0 / 3.0) + Acos(k * x) / Log(Asin(k * x)); 
        }
        static void Main(string[] args)
        {
            int k,x, xmin, xmax, dx;
            double z;
            StreamReader sr = new StreamReader("C:\\Users\\Слава\\Documents\\Visual Studio 2017\\Projects\\pr10\\TextFile1.txt");
            k = Convert.ToInt32(sr.ReadLine());
            dx = Convert.ToInt32(sr.ReadLine());
            xmin = Convert.ToInt32(sr.ReadLine());
            xmax = Convert.ToInt32(sr.ReadLine());
            StreamWriter sw = new StreamWriter("C:\\Users\\Слава\\Documents\\Visual Studio 2017\\Projects\\pr10\\TextFile2.txt");
            for (x = xmin; x <= xmax; x+=dx)
            {
                z = func(k,x);
                Console.WriteLine("x={0}   z={1}", x, z);
                sw.WriteLine("x={0}    z={1}", x, z);
            }
            sw.Close();
            Console.ReadKey();

        }
    }
}

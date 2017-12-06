using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    class Program
    {
        static double GetField( String textForUser)
        {
            Console.Write(textForUser);
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double a, x, c, y;
            a = x = c =  y = 0;
            
            Console.WriteLine(" 1 Task ");
            x = GetField(" Enter x = ");
            a = GetField(" Enter a = ");
            c = GetField(" Enter c = ");

            y = Pow(c*x - a, 1.0 / 3.0) + Log(x)/2*Asin(PI/3 + x);
            Console.Write(" y = " +  y + ";\n");

            double xmin, xmax, dx;
            xmin = xmax = dx = 0;
            Console.WriteLine(" 2 Task ");
            c = GetField(" Enter c = ");
            xmin = GetField(" Enter xmin = ");
            xmax = GetField(" Enter xmax = ");
            dx = GetField(" Enter dx = ");

            while (xmin <= xmax) {
                y = Pow(Pow(c, 2.0) * Pow(xmin, 2.0) + 2, 1.0 / 3.0) + Log(Pow(xmin, 2.0) + 1) /( 2 * Math.PI);
                Console.Write(" y = " + y + ";\n");
                xmin += dx;
            }


            double k = 0;
            Console.WriteLine(" 3 Task ");
            a = GetField(" Enter a = ");
            k = GetField(" Enter k = ");
            xmin = GetField(" Enter xmin = ");
            xmax = GetField(" Enter xmax = ");
            dx = GetField(" Enter dx = ");

            while (xmin <= xmax)
            {
                y = Pow(Acos(a*xmin), 1.0 / 3.0) + Acos(a*xmin) / Log(a*xmin);
                Console.Write(" y = " + y + "; \n");
                xmin += dx;
            }
            Console.ReadLine();
        }
    }
}

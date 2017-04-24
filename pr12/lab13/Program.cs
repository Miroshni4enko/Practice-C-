using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    
    class Program
    {
        static void Input(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}й: ", i + 1);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        delegate double Delegate(double a);
        static double Sum(double[] a, Delegate b)
        {
            double s = 0;
            for (int i = 0; i < a.Length; i++)
                s += a[i]*b(a[i]);
            return s;
        }
        static double Sum(double[] a)
        {
            double s = 0;
            for (int i = 0; i < a.Length; i++)
                s += a[i];
            return s;
        }
        static double Multi(double[] a, Delegate b)
        {
            double p = 1;
            for (int i = 0; i < a.Length; i++)
                p *= a[i]*b(a[i]);
            return p;
        }
        static double Multi(double[] a)
        {
            double p = 1;
            for (int i = 0; i < a.Length; i++)
                p *= a[i];
            return p;
        }
        static void ABC(double[] a, out double A, out double B, out double C, Delegate b, Delegate c, Delegate d)
        {
            A = Sum(a) * Sum(a, b);
            B = Multi(a) * Sum(a, b);
            C = (Sum(a) + Multi(a)) * Sum(a, b);
        }
        static void Main(string[] args)
        {
            double Y, A, B, C, D, E, F;
            Console.WriteLine("Введите количество элементов x");
            double[] x = new double[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Введите количество элементов y");
            double[] y = new double[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Введите массив x");
            Input(x);
            Console.WriteLine("Введите массив y");
            Input(y);
            ABC(x, out A, out B, out C, Math.Sin, Math.Cos, Math.Tan);
            ABC(y, out D, out E, out F, Math.Tan, Math.Exp, Math.Cos);
            Y = (A + B * Math.Cos(C)) / (D + E * Math.Sin(F));
            Console.WriteLine("Результат " + Y);
            Console.ReadKey();
        }
    }
}

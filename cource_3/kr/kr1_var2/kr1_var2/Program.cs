using System;

namespace kr1_var2
{
    class Program
    {
        static long sfaktorial(int n)
        {
            long i;
            long p = 1;
            long s = 0;
            for (i = 1; i <= n; i++)
            {
                p *= i;
                s = s + p;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int k;
          
            Console.WriteLine("Vvedite chislo:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine(sfaktorial(k));
            Console.ReadLine();            
        }
    }
}

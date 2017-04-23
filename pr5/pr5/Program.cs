using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    class Program
    {
        static int GetField(String textForUser)
        {
            Console.Write(textForUser);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] CreateAndFillMass(int length, int min, int max) {
            int[] mass = new int[length];
            Random random = new Random();
            for (int i = 0; i<length; i++) {
                mass[i] =  random.Next(min,max);
            }
            return mass;
        }

        static void printMass(int[] growth, int[] weight) {
            for (int i = 0; i < growth.Length; i++) {
                Console.WriteLine("growth =" + growth[i] + "weight =" + weight[i]);
            }
        }
        static void Main(string[] args)
        {
            int [] growth, weight;
            growth = CreateAndFillMass(GetField("length mass for growth = "), GetField("min = "), GetField("max ="));
            weight = CreateAndFillMass(GetField("length mass for weight = "), GetField("min = "), GetField("max ="));
            Array.Sort(growth, weight);
            printMass(growth, weight);
            Console.ReadKey();
        }
    }
}

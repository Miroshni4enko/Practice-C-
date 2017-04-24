using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Program
    {
        static int GetField( String textForUser)
        {
            Console.Write(textForUser);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] createAndFillMass(int element)
        {
            
            int[] mass = new int[element];
            for (int i = 0; i < element; i++)
            {
                mass[i] = GetField("el mass = ");
            }
            return mass;
        }

        static void taskInPr(int[] mass, int enterNum, string textForUser)
        {
            Console.WriteLine(textForUser);
            int product = 1, summ = 0, numOfZero = 0;
            foreach (int i in mass) {
                if (i > enterNum & i < 0) {
                    summ += i;
                } else if (i > 0){
                    product *= i;
                } else{
                    numOfZero++;
                }
            }
            Console.WriteLine(" Number of ziro =" + numOfZero + 
                "; Product = " + product + "; Summ = " + summ + ";");
        }


        static void Main(string[] args)
        {
            int [] m1, m2, m3;
            int enterNum;
            m1 = createAndFillMass(GetField(" Enter length 1 mass "));
            m2 = createAndFillMass(GetField(" Enter length 2 mass "));
            m3 = createAndFillMass(GetField(" Enter length 3 mass "));
            enterNum = GetField(" Enter number: ");
            taskInPr(m1, enterNum, "Result for mass 1 ");
            taskInPr(m2, enterNum, "Result for mass 2 ");
            taskInPr(m3, enterNum, "Result for mass 3 ");
        }
    }
}

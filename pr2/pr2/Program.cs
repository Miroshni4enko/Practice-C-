using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    class Program
    {
        static private String forConvert;
        static int[,] createAndFillMass(int column, int line) {
            int[,] massToFill = new int[column, line];           
            for (int c = 0; c<column;c++) {
                for (int l = 0; l < line; l++) {
                    Console.Write("el mass = ");
                    forConvert = Console.ReadLine();
                    massToFill[c, l] = Convert.ToInt32(forConvert);
                }    
                
            }
            return massToFill;
        }

        static int[] createAndFillVector(int column) {
            int[] vector = new int[column];
            for (int l = 0; l < column; l++){
                Console.Write("el vectora = ");
                forConvert = Console.ReadLine();
                vector[l] = Convert.ToInt32(forConvert);
            }
            return vector;
        }
        static int[] multiplyVectorOnMass(int column,int line, int[,] mass, int [] vector){
            int[] result = new int [column] ;
            for (int c = 0; c < column; c++)
            {
                for (int l = 0; l < line; l++)
                {
                    result[c] = result[c] + mass[c, l] * vector[c]; 
                }

            }
            return result;
        }

        static void printMass(int[] mass) {
            foreach (int i in mass) {
                Console.WriteLine("el =" + i);
            }
        }
        static void executeTask1()
        {
            int column, line;
            Console.WriteLine("Task1");
            Console.WriteLine("Enter number of colum");
            forConvert = Console.ReadLine();
            column = Convert.ToInt32(forConvert);

            Console.WriteLine("Enter number of line");
            forConvert = Console.ReadLine();
            line = Convert.ToInt32(forConvert);

            Console.WriteLine("Fill mass");
            int[,] mass = createAndFillMass(column, line);

            Console.WriteLine("Fill vector");
            int[] vector = createAndFillVector(column);

            Console.WriteLine("Result of multiply");
            int[] result = multiplyVectorOnMass(column, line, mass, vector);
            printMass(result);
        }

        static int[,] AverageForTask2(int column, int line, int[,] mass)
        {
            for (int c = 0; c < column; c++)
            {
                int summOfLine = 0;
                for (int l = 0; l < line; l++)
                {
                    summOfLine += mass[c, l];
                }
                int averageOfLine = summOfLine / line;
                for (int l = 0; l < line; l++)
                {
                    mass[c, l] -= averageOfLine;
                }
            }
            return mass;
        }
        static void printMass(int[,] mass)
        {
            foreach (int i in mass)
            {
                Console.Write("el =" + i);
            }
            Console.WriteLine();
        }
        static void executeTask2()
        {
            int column, line;
            Console.WriteLine("Task1");
            Console.WriteLine("Enter number of colum");
            forConvert = Console.ReadLine();
            column = Convert.ToInt32(forConvert);

            Console.WriteLine("Enter number of line");
            forConvert = Console.ReadLine();
            line = Convert.ToInt32(forConvert);

            Console.WriteLine("Fill mass");
            int[,] mass = createAndFillMass(column, line);
            mass = AverageForTask2(column, line, mass);
            printMass(mass);

        }
            static void Main(string[] args)
        {
            executeTask1();
            executeTask2();
            Console.ReadKey();
            
        }
    }
}

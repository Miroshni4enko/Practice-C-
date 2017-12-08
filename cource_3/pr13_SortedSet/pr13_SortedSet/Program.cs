using System;

namespace pr13_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Viacheslav", new System.Collections.Generic.SortedSet<Int32>(new[] { 95, 54, 67, 32, 78 }));
            //Enqueue - add element to queue
            student.marks.Add(77);

            // find max of marks
            int max = student.marks.Max;
            

            Console.WriteLine("Student " + student.name + " max of marks = " + max);
            Console.ReadLine();
        }
    }
}

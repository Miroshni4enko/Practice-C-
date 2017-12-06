using System;
using System.Collections.Generic;

namespace pr8_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Viacheslav", new Queue<Int32>(new[] { 95, 54, 67, 32, 78 }));
            //Enqueue - add element to queue
            student.marks.Enqueue(77);
           
            // find average of marks
            int sum = 0;
            int initCount = student.marks.Count;
            for (; student.marks.Count > 0;) {
                //Dequeue - remove element from queue and get 
                sum +=student.marks.Dequeue();
            }
            try
            {
                //peek - get head element without remove 
                //try get element from empty queue
                student.marks.Peek();
            }
            catch (InvalidOperationException w)
            {
                Console.WriteLine("Error! {0}", w.Message);
            }

            Console.WriteLine("Student " + student.name + " avarege of marks = " + sum / initCount);
            Console.ReadLine();
        }
    }
}

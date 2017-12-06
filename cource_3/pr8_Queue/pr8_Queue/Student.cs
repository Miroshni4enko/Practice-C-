using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_Queue
{
    class Student
    {
        public String name { get; set; }
        public Queue<Int32> marks { get; set; }

    public Student(String name, Queue<Int32> marks) {
            this.name = name;
            this.marks = marks;
        }


    }
}

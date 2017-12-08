using System;
using System.Collections.Generic;
using System.Text;

namespace pr13_SortedSet
{
    class Student
    {
        public String name { get; set; }
        public SortedSet<Int32> marks { get; set; }

    public Student(String name, SortedSet<Int32> marks) {
            this.name = name;
            this.marks = marks;
        }


    }
}

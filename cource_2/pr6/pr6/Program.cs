using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "vyacheslav ";
            string sername = "miroshnichenko  ";
            string fullName = String.Concat(name + sername);
            Console.WriteLine("Concat " + fullName);
            Console.WriteLine("Insert " + fullName.Insert(27, "is"));
            Console.WriteLine("Remove " + fullName.Remove(11, 14));
            Console.WriteLine("Replace " + fullName.Replace("v", "V"));
            Console.WriteLine("Equals " + fullName.Equals("vyacheslav miroshnichenko  "));
            Console.WriteLine("Compare " + String.Compare(fullName, 0, "vyac", 0, 4));
            Console.WriteLine("Index of " + fullName.IndexOf("mirosh"));
            Console.ReadKey();

        }
    }
}

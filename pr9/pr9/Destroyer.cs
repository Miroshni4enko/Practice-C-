using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9
{
    class Destroyer : Plane
    {
        string name;
        
        public override void input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }

        public override string output()
        {
            return "name" + name;
        }
    }
}

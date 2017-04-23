using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9
{
    class PassengerLiner : Plane
    {
        private int numOfPass;
        public override void input()
        {
            string forConvert;
            Console.WriteLine("Enter number of passenger");
            forConvert = Console.ReadLine();
            numOfPass = Convert.ToInt32(forConvert);
        }

        public override string output()
        {
            return "number of passenger = " + numOfPass;
        }
    }
}

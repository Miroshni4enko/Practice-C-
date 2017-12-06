using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_inherit
{
    class Ship
    {
        private string name;
        private string function;
        private int cavity, enginePower, fuel;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}

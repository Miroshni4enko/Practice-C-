using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus
    {
        private string brand;
        private int numOfPass;
        private int maxSpeed;
        private int price;

        public Bus(string brand, int numOfPass,int maxSpeed,int price)
        {
            this.brand = brand;
            this.numOfPass = numOfPass;
            this.maxSpeed = maxSpeed;
            this.price = price;
        }

        public static bool operator !=(Bus ob1, Bus ob2)
        {
            if (ob1.brand != ob2.brand || ob1.maxSpeed != ob2.maxSpeed || ob1.numOfPass != ob2.numOfPass || ob1.price != ob2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Bus ob1, Bus ob2)
        {
            if (ob1.brand == ob2.brand && ob1.maxSpeed == ob2.maxSpeed && ob1.numOfPass == ob2.numOfPass && ob1.price == ob2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Bus ob1, Bus ob2)
        {
            if (ob1.brand.CompareTo(ob2.brand) <= 0  && ob1.maxSpeed <= ob2.maxSpeed && ob1.numOfPass <= ob2.numOfPass && ob1.price <= ob2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Bus ob1, Bus ob2)
        {
            if (ob1.brand.CompareTo(ob2.brand) >= 0 && ob1.maxSpeed >= ob2.maxSpeed && ob1.numOfPass >= ob2.numOfPass && ob1.price >= ob2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Bus operator +(Bus ob1, Bus ob2)
        {
            return new Bus(ob1.brand + ob2.brand, ob1.numOfPass + ob2.numOfPass, ob1.maxSpeed + ob2.maxSpeed, ob1.price + ob2.price);
        }

        public string toString()
        {
            return "brand = " + brand + " numOfPass = " +  numOfPass + " maxSpeed = " + maxSpeed + " price = " + price;
        }

    }
}

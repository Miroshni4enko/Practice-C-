using System;
using System.Collections.Generic;
using System.Text;

namespace pr9_Arrays_IComparable_IComparer
{
    public class Detail : IComparable<Detail>
    {
        public String name { get; set; }
        public Int32 weight { get; set; }


        public Detail(String name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        public Detail()
        {
        }

        public class  CompareDetail: IComparer<Detail> {
          
            public int Compare(Detail firstDatail, Detail secondDatail)
                {
                    if (!firstDatail.name.Equals(secondDatail.name))
                    {
                        return firstDatail.name.CompareTo(secondDatail.name);
                    }
                    else
                    {
                        return firstDatail.weight.CompareTo(secondDatail.weight);
                    }
                }
           }
        public static IComparer<Detail> GetComparer()
        {
                return new CompareDetail();
        }

        public int CompareTo(Detail obj)
        {
            if (this.name.Equals(obj.name))
            {
                return this.name.CompareTo(obj.name);
            }
            else
            {
                return this.weight.CompareTo(obj.weight);
            }
        }
    }
}

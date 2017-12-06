using System;
using System.Collections.Generic;


namespace pr9_Arrays_IComparable_IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Detail> listDetail = new List<Detail>
            {
                new Detail("first", 4),
                new Detail("second", 5),
                new Detail("first", 7),
                new Detail("third", 4),
                new Detail("second", 4),
                new Detail("third", 2)
            };

            listDetail.Sort(Detail.GetComparer());
            Console.WriteLine(listDetail);

            foreach(Detail d in listDetail){
                Console.WriteLine(d.name + "  " + d.weight);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace pr12_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of weddings");
            int amountOfWedd = Int32.Parse(Console.ReadLine());

            Stack<Wedding> stackOfWedd = new Stack<Wedding>(amountOfWedd);
            for (int i = 1; i <= amountOfWedd; i++)
            {
                Console.WriteLine("Enter address");
                String address = Console.ReadLine();
                Console.WriteLine("Enter name of The Bride");
                String bride = Console.ReadLine();
                Console.WriteLine("Enter name of the Bridegroom ");
                String bridegroom = Console.ReadLine();
                Console.WriteLine("Enter amount of guests");
                int amountOfGuests = int.Parse(Console.ReadLine());
                stackOfWedd.Push(new Wedding(address, bride, bridegroom, amountOfGuests));
            }
            for (; stackOfWedd.Count > 0;)
            {
                //pop - get head element with remove 
                Console.WriteLine(stackOfWedd.Pop().toString());
            }
            try
            {
                //peek - get head element without remove 
                //try get element from empty queue
                stackOfWedd.Peek();
            }
            catch (InvalidOperationException w)
            {
                Console.WriteLine("Error! {0}", w.Message);
            }
            Console.ReadLine();
        }
    }
}

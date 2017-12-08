using System;
using System.Collections.Generic;

namespace pr10_var3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of weddings");
            int amountOfWedd = Int32.Parse(Console.ReadLine());
      
            List<Wedding> listOfWedd = new List<Wedding>(amountOfWedd);
            for (int i = 1; i <= amountOfWedd; i++) {
                Console.WriteLine("Enter address");
                String address = Console.ReadLine();
                Console.WriteLine("Enter name of The Bride");
                String bride = Console.ReadLine();
                Console.WriteLine("Enter name of the Bridegroom ");
                String bridegroom = Console.ReadLine();
                Console.WriteLine("Enter amount of guests");
                int amountOfGuests = int.Parse(Console.ReadLine());
                listOfWedd.Add(new Wedding(address, bride, bridegroom, amountOfGuests));
            }
            foreach (Wedding w in listOfWedd) {
                Console.WriteLine(w.toString());
            }
            Console.ReadLine();

        }
    }
}

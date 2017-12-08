using System;
using System.Collections.Generic;
using System.Text;

namespace pr10_var3
{

    class Wedding
    {
        public String address { get; set; }
        public String nameOfTheBride { get; set; }
        public String nameOfTheBridegroom { get; set; }
        public Int32 amountOfGuests { get; set; }

        public Wedding(String address, String nameOfTheBride, String nameOfTheBridegroom, Int32 amountOfGuests)
        {
            this.address = address;
            this.amountOfGuests = amountOfGuests;
            this.nameOfTheBride = nameOfTheBride;
            this.nameOfTheBridegroom = nameOfTheBridegroom;
        }

        public String toString() {
            return "Wedding : " + " address - " + address + "Bride - " + nameOfTheBride + "Bridegroom - " + nameOfTheBridegroom + "Amount of guests = " + amountOfGuests;
        } 
    }
}

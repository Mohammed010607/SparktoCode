using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Guest
    {
        public string guestID {  get; private set; }
        public string guestName { get; private set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; private set; }
        public int totalNights { get; set; }
        
        public Guest(string guestID, string guestName, string checkInDate, int totalNights)
        {
            this.guestID = guestID;
            this.guestName = guestName;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
            roomNumber = "Not Assigned";
        }

        public void displayGuest()
        {
            Console.WriteLine(guestID);
            Console.WriteLine(guestName);
            Console.WriteLine(roomNumber);
            Console.WriteLine(checkInDate);
            Console.WriteLine(totalNights);

        }
        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
        }
    }
}

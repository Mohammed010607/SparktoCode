using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Room
    {
        public int roomNumber {get; private set; }
        public string roomType {get; private set;}
        public double pricePerNight{ get; set;}
        public bool isAvailable { get; set;}

        public Room(int roomNumber,string roomType,double pricePerNight)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            isAvailable = true;
        }

        public void displayRoom()
        {
            Console.WriteLine(roomNumber);
            Console.WriteLine(roomType);
            Console.WriteLine(pricePerNight.ToString("F2"));
            Console.WriteLine(isAvailable);
        }
    }
}

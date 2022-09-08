using System;
namespace HotelReservation.hotel
{
    public class Hotel
    {
        private string id; // the id of the hotel
        private string name; // the name of the hotel
        private string roomNo; 
        private string reservedBy; // the username of the reserver

        public Hotel(string id, string name, string roomNo)
        {
            this.id = id;
            this.name = name;
            this.roomNo = roomNo;
            reservedBy = "";
        }

        public void Reserve(string user)
        {
            reservedBy = user;
        }

        /// <summary>
        /// Display the details of the hotel to the user
        /// </summary>
        public void DisplayDetails()
        {
            string isReserved = (reservedBy.Length > 0) ? "Yes" : "No";
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("ROOM NO: " + roomNo);
            Console.WriteLine("IS RESERVED: " + isReserved);
            if (reservedBy.Length > 0) Console.WriteLine("RESERVED BY: " + reservedBy); // is reserved
            Console.WriteLine("----------------------------------------------");
        }
    }
}

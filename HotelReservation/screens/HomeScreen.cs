using System;
using System.Collections.Generic;
using HotelReservation.hotel;

namespace HotelReservation.screens
{
    public class HomeScreen : Screen
    {
        private LinkedList<Hotel> hotelList; // list of all hotels in the registry
        //private LinkedList<Reservation> reservationList; // list of all reservations made by the logged in user

        public HomeScreen()
        {
            hotelList = new LinkedList<Hotel>();
            PopulateHotelList();
        }

        public void PopulateHotelList()
        {
            hotelList.AddLast(new Hotel("001", "La Vida", "AB12"));
            hotelList.AddLast(new Hotel("002", "Crescent", "AZ22"));
            hotelList.AddLast(new Hotel("003", "Medussa", "DR312"));
            hotelList.AddLast(new Hotel("004", "La Papel", "A012"));
            hotelList.AddLast(new Hotel("005", "Shelton", "BN12N"));
            hotelList.AddLast(new Hotel("006", "Bay Front", "ZX47"));

        }

        public void ViewAllHotels()
        {
            foreach(Hotel hotel in hotelList)
            {
                hotel.DisplayDetails();
            }
            Console.WriteLine("[ " + hotelList.Count + " hotels displayed. ]");
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Render()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-                 HOME                  -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-       Press H to View all Hotels      -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-     Press R to View all Reservations  -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-            Press Q to Quit            -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-----------------------------------------");
        }

        public override bool H()
        {
            ViewAllHotels();
            return true;
        }
    }
}

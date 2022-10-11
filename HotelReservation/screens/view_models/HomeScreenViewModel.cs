using System;
using System.Collections.Generic;
using HotelReservation.commands;
using HotelReservation.models.hotel;
using HotelReservation.utility;

namespace HotelReservation.screens.view_models
{
    public class HomeScreenViewModel : ScreenViewModel
    {
        private LinkedList<Hotel> hotelList; // list of all hotels in the registry

        public HomeScreenViewModel()
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
            foreach (Hotel hotel in hotelList)
            {
                hotel.DisplayDetails();
            }
            Console.WriteLine("[ " + hotelList.Count + " hotels displayed. ]");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Logout()
        {
            DatabaseUtility.loggedInUser = null;
            Navigator.Instance.PreviousScreen();
        }

        public override bool H()
        {
            ViewAllHotels();
            return true;
        }

        public override bool P()
        {
            DatabaseUtility.Instance.PrintAllUsersDetails(); // for debugging (delete later)
            return true;
        }

        public override bool L()
        {
            Logout();
            return true;
        }
    }
}

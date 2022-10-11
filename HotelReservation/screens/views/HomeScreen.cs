using System;
using System.Collections.Generic;
using HotelReservation.models.hotel;
using HotelReservation.screens.view_models;
using HotelReservation.utility;

namespace HotelReservation.screens.views
{
    public class HomeScreen : Screen
    {
        public HomeScreen(HomeScreenViewModel homeScreenViewModel)
        {
            // READ THE TODO.TXT
            _screenViewModel = homeScreenViewModel;
        }

        public HomeScreen()
        {
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
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-     Press R to View all Reservations  -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-            Press L to Logout          -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-             Press Q to Quit           -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-----------------------------------------");
        }

        
    }
}

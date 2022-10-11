using System;
using System.Collections.Generic;
using HotelReservation.utility;
using HotelReservation.models.user;
using HotelReservation.screens.view_models;

namespace HotelReservation.screens.views
{
    public class MenuScreen : Screen
    {
        //List<User> allUsers;
        //string allUsersFilePath;

        public MenuScreen()
        {
            _screenViewModel = new MenuScreenViewModel();
            //allUsersFilePath = "/Users/emmanuelozioma/Projects/HotelReservation/HotelReservation/data/all_users.txt";
            // allUsers = Util.Instance.FetchAllUsers();
            //allUsers =  DatabaseUtility.Instance.FetchAllUsers(allUsersFilePath);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Render()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-            LOGIN / REGISTER           -");
            Console.WriteLine("-                                       -");                                                                                                                                                                                                                                                                                                                                                                                         
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-            Press L to Login           -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-           Press R to Register         -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-             Press Q to Quit           -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-                                       -");
            Console.WriteLine("-----------------------------------------");
        }

        

    }
}

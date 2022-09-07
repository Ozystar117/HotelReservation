using System;
using HotelReservation.screens;
using System.Collections.Generic;
using HotelReservation.utility;

namespace HotelReservation.screens
{
    public class MenuScreen : Screen
    {
        public MenuScreen()
        {
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

        public void Login(string uName="", string pwd="")
        {
            if(uName.Length <= 0)
            {
                Console.WriteLine("> Enter username");
                string username = Console.ReadLine();
            }

            if(pwd.Length <= 0)
            {
                Console.WriteLine("> Enter password");
                string password = Console.ReadLine();
            }

            // TODO: Validate User Details

            Navigator.Instance.NavigateReplace(new HomeScreen());
        }

        public void Register()
        {
            Console.WriteLine("> Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("> Enter password");
            string password = Console.ReadLine();

            bool isValid = Authenticator.Instance.VerifyPasswordFormat(password, 6);

            if (isValid)
            {
                // TODO: Save the user's details to the database

                Login(username, password); // login the user
            }
        }

        public override bool L()
        {
            Login();
            return true;
        }

        public override bool R()
        {
            Register();
            return true;
        }
        
    }
}

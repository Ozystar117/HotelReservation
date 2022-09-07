using System;
using System.Collections.Generic;

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

        public void Login()
        {
            Console.WriteLine("> Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("> Enter password");
            string password = Console.ReadLine();

            //TODO: Validate Input Format

            // Validate User Details
        }

        public void Register()
        {
            // TODO: Allow users to register
        }

        public override bool L()
        {
            Login();
            return true;
        }
        
    }
}

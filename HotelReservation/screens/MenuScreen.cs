using System;
using System.Collections.Generic;
using HotelReservation.utility;
using HotelReservation.user;

namespace HotelReservation.screens
{
    public class MenuScreen : Screen
    {
        List<User> allUsers;
        string allUsersFilePath;

        public MenuScreen()
        {
            allUsersFilePath = "/Users/emmanuelozioma/Projects/HotelReservation/HotelReservation/data/all_users.txt";
            // allUsers = Util.Instance.FetchAllUsers();
            allUsers =  DatabaseUtil.Instance.FetchAllUsers(allUsersFilePath);
        }

        public void PrintAllUsersDetails() // for testing (delete later)
        {
            foreach(User user in allUsers)
            {
                user.PrintDetails();
            }
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

        /// <summary>
        /// Login the user
        /// Navigate to the home screen after successful login
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="pwd"></param>
        public void Login(User user = null)
        {
            string username = "";
            string password = "";

            if(user == null)
            {
                Console.WriteLine("> Enter username");
                username = Console.ReadLine();
            
                Console.WriteLine("> Enter password");
                password = Console.ReadLine();

                user = new User(username, password);
            }

            
            // TODO: Validate User Details

            foreach(User u in allUsers)
            {
                if(user.GetUserName() == u.GetUserName() && user.GetPassword() == u.GetPassword())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Logged in successfully");
                    Console.WriteLine("-----------------------------------");
                    Navigator.Instance.NavigateReplace(new HomeScreen());
                    return;
                }
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Username or password is incorrect");
            Console.WriteLine("-----------------------------------");
        }

        /// <summary>
        /// Enable users to create an account
        /// The format of the password is verified
        /// Ensure that users are automatically logged in after successfully creating an account
        /// </summary>
        public void Register()
        {
            List<string> lines = new List<string>();

            Console.WriteLine("> Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("> Enter password");
            string password = Console.ReadLine();

            bool isValid = Authenticator.Instance.VerifyPasswordFormat(password, 6); // verify that the format of the password supplied is correct

            if (isValid)
            {
                // TODO: Save the user's details to the database

                User user = new User(username, password);
                if (DatabaseUtil.Instance.UpdateAllUsersFile(user))
                {
                    allUsers.Add(user);
                    Login(user); // login the user
                }
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

        public override bool H()
        {
            PrintAllUsersDetails();
            return base.H();
        }

    }
}

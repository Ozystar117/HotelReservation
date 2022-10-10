using System;
using System.Collections.Generic;
using HotelReservation.utility;
using HotelReservation.user;

namespace HotelReservation.screens
{
    public class MenuScreen : Screen
    {
        //List<User> allUsers;
        //string allUsersFilePath;

        public MenuScreen()
        {
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

        /// <summary>
        /// Login the user
        /// Navigate to the home screen after successful login
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="pwd"></param>
        public void Login(User user = null)
        {

            if(user == null)
            {
                Console.WriteLine("> Enter username");
                string username = Console.ReadLine();
            
                Console.WriteLine("> Enter password");
                string password = Console.ReadLine();

                user = new User(username, password);
            }

            foreach(User u in DatabaseUtility.allUsers)
            {
                if(user.GetUserName() == u.GetUserName() && user.GetPassword() == u.GetPassword())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Logged in successfully");
                    Console.WriteLine("-----------------------------------");

                    DatabaseUtility.loggedInUser = user; // update the ref to the logged in user

                    Navigator.Instance.Navigate(new HomeScreen());
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
                if (DatabaseUtility.Instance.UpdateAllUsersFile(user))
                {
                    DatabaseUtility.allUsers.Add(user);
                    Login(user); // login the user
                }
                else
                {
                    Console.WriteLine("Error registering");
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
            DatabaseUtility.Instance.PrintAllUsersDetails();
            return base.H();
        }

    }
}

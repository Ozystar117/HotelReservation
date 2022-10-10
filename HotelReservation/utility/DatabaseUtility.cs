using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HotelReservation.user;

namespace HotelReservation.utility
{
    public class DatabaseUtility
    {
        private static DatabaseUtility instance;

        static string allUsersFilePath = "/Users/emmanuelozioma/Projects/HotelReservation/HotelReservation/data/all_users.txt";
        public static List<User> allUsers = FetchAllUsers(allUsersFilePath);

        public static User loggedInUser; // ref to the logged in user


        public DatabaseUtility()
        {
            loggedInUser = null;
        }

        public static DatabaseUtility Instance
        {
            get
            {
                if (instance == null) instance =  new DatabaseUtility();
                return instance;
            }
        }

        public static List<User> FetchAllUsers(string allUsersFilePath)
        {
            List<string> list = File.ReadAllLines(allUsersFilePath).ToList();
            List<User> users = new List<User>();

            foreach (string userStr in list)
            {
                string[] userDetails = userStr.Split(',');
                string username = userDetails[0];
                string password = userDetails[1];

                User user = new User(username, password);
                users.Add(user);
            }

            return users;
        }

        public bool UpdateAllUsersFile(User user)
        {
            List<string> lines = new List<string>();

            foreach(User existingUser in allUsers)
            {
                lines.Add(existingUser.GetUserName() + "," + existingUser.GetPassword());
                lines.Add(user.GetUserName() + "," + user.GetPassword());
            }

            try
            {
                File.WriteAllLines(allUsersFilePath, lines); // save the lines to a file
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }

        public void PrintAllUsersDetails() // for testing (delete later)
        {
            foreach (User user in allUsers)
            {
                user.PrintDetails();
            }
            Console.WriteLine($"[Logged in: {loggedInUser?.GetUserName()}]");
        }
    }
}

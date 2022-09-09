using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HotelReservation.user;

namespace HotelReservation.utility
{
    public class DatabaseUtil
    {
        private static DatabaseUtil instance;
        string allUsersFilePath;

        public DatabaseUtil()
        {
        }

        public static DatabaseUtil Instance
        {
            get
            {
                if (instance == null) instance = new DatabaseUtil();
                return instance;
            }
        }

        public List<User> FetchAllUsers(string allUsersFilePath)
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

            lines.Add(user.GetUserName() + "," + user.GetPassword());

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
    }
}

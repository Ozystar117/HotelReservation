using System;
namespace HotelReservation.models.user
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUserName()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void PrintDetails()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("username: " + username);
            Console.WriteLine("password: " + password);
            Console.WriteLine("-----------------");
        }
    }
}

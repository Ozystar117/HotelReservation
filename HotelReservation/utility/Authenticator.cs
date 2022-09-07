using System;
using System.Collections.Generic;
namespace HotelReservation.utility
{
    public class Authenticator
    {
        private static Authenticator instance;

        private Authenticator()
        {

        }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null) instance = new Authenticator();
                return instance;
            }
        }

        public bool VerifyPasswordFormat(string password, int minLength)
        {

            Console.WriteLine("-----------------------------------------------------------------");
            bool length = CheckPasswordLength(password, minLength);
            bool uppercase = CheckForUpperCase(password);
            bool lowercase = CheckForLowerCase(password);
            bool digit = CheckForNumbers(password);


            if (length && uppercase && lowercase && digit) {
                Console.WriteLine("Password is accepted");
                Console.WriteLine("-----------------------------------------------------------------");
                return true;
            }


            Console.WriteLine("-----------------------------------------------------------------");

            return false;

        }

        private bool CheckPasswordLength(string password, int minLength)
        {
            if (password.Length < minLength) {
                Console.WriteLine("Error: Password must be at least " + minLength + " digit long");
                return false;
            }

            return true;
        }

        private bool CheckForUpperCase(string password)
        {
            LinkedList<char> list = new LinkedList<char>();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                list.AddLast(c); // populate list
            }

            for(int i = 0; i < password.Length; i++)
            {
                if (list.Contains(password[i])) return true; // uppercase found
            }

            Console.WriteLine("Error: Password must contain an uppercase letter");

            return false;
        }

        private bool CheckForLowerCase(string password)
        {
            LinkedList<char> list = new LinkedList<char>();

            for (char c = 'a'; c <= 'z'; c++)
            {
                list.AddLast(c); // populate list
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (list.Contains(password[i])) return true; // lowercase found
            }

            Console.WriteLine("Error: Password must contain a lower case letter");
            return false;
        }

        private bool CheckForNumbers(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i])) return true; // number found
            }
            Console.WriteLine("Error: Password must contain at least one number");

            return false;
        }





    }
}

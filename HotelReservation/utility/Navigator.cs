using System;
using System.Collections.Generic;
using HotelReservation.screens.views;

namespace HotelReservation.utility
{
    public class Navigator
    {
        private static Navigator instance;
        private Stack<Screen> screenManager;

        private Navigator()
        {
            screenManager = StartApp.Instance.GetScreenManager();
        }

        public static Navigator Instance
        {
            get
            {
                if (instance == null) instance = new Navigator();
                return instance;
            }
        }

        /// <summary>
        /// Navigate to the specified screen and remove the current screen from the navigation stack
        /// </summary>
        /// <param name="destination"></param>
        public void NavigateReplace(Screen destination)
        {
            screenManager.Pop(); // remove the current screen from the stack
            screenManager.Push(destination); // push the specified screen to the stack
        }

        /// <summary>
        /// Navigate to the specified screen
        /// </summary>
        /// <param name="destination"></param>
        public void Navigate(Screen destination)
        {
            screenManager.Push(destination); // navigate to the specified screen
        }

        /// <summary>
        /// Enables the user go back to the previous screen
        /// </summary>
        public void PreviousScreen()
        {
            screenManager.Pop();
        }


    }
}

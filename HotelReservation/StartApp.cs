using System;
using System.Collections.Generic;
using HotelReservation.screens;

namespace HotelReservation
{
    public class StartApp : IApp
    {
        public static bool ISRUNNING = true; // used to update the application loop
        private Stack<Screen> screenManager = new Stack<Screen>(); // handle screen management

        private static StartApp instance = null;

        private StartApp()
        {
            screenManager.Push(new MenuScreen()); // init the stack with the menu screen
        }

        public static StartApp Instance
        {
            get {
                if (instance == null) instance = new StartApp();
                return instance;
            }
        }

        public Stack<Screen> GetScreenManager()
        {
            return screenManager;
        }

        public void Start()
        {
            Update(); 
        }

        public void Update()
        {
            while (ISRUNNING) // while the app is running
            {
                Screen currentScreen = screenManager.Peek();

                currentScreen.Update(); // update the screen at the top of the stack
            }

        }

        public void Render()
        {

        }


    }
}

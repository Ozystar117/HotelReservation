using System;
using System.Collections.Generic;
using HotelReservation.commands;
using HotelReservation;
using HotelReservation.screens.view_models;

namespace HotelReservation.screens.views
{
    public class Screen : IView
    {
        // Change To Controller
        protected ScreenViewModel _screenViewModel;

        public Screen()
        {
            _screenViewModel = new ScreenViewModel(); // override this in sub-classes
        }

        public virtual void Update()
        {
            Render();

            _screenViewModel.Listen(); // listen for commands via the view model
        }

        public virtual void Render()
        {
            // override in sub-classes
        }
    }
}

using System;
using System.Collections.Generic;
using HotelReservation.commands;

namespace HotelReservation.screens
{
    public class Screen : CommandManager, IApp
    {
        public Screen()
        {

        }

        public virtual void Update()
        {
            Render();
            // commandmanager.listen();
            Listen();
        }

        public virtual void Render()
        {
            
        }

        public static explicit operator Screen(Type v)
        {
            throw new NotImplementedException();
        }
    }
}

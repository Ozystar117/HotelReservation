using NUnit.Framework;
using HotelReservation;
using HotelReservation.screens;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture()]
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test that when the user taps the 'Q' in any screen the application quits
        /// </summary>
        /// <param name="screen"></param>
        [TestCaseSource(nameof(ApplicationRunningTestCases))]
        public void TestApplicationRunning_IsFalse(Screen screen)
        {
            screen.Q();
            Assert.IsFalse(StartApp.ISRUNNING);
        }

        private static readonly object[] ApplicationRunningTestCases =
         {
            new object[]{ new MenuScreen(), },
            new object[]{ new MenuScreen(), },
        };
    }
}

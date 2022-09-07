using NUnit.Framework;
using HotelReservation;
using HotelReservation.screens;
using HotelReservation.commands;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture()]
    public class Test
    {
        private CommandManager commandManager { get; set; } = CommandManager.Instance;
        Dictionary<string, Func<bool>> commandDictionary;

        [SetUp]
        public void Setup()
        {
            commandDictionary = CommandManager.Instance.getCommandDictionary();
        }

        #region Test Application Quit
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

        #endregion

        #region Test cases for listen for command are equal
        [TestCase("a")]
        [TestCase("b")]
        [TestCase("c")]
        [TestCase("d")]
        [TestCase("e")]
        [TestCase("f")]
        [TestCase("g")]
        [TestCase("h")]
        [TestCase("i")]
        [TestCase("j")]
        [TestCase("k")]
        [TestCase("l")]
        [TestCase("m")]
        [TestCase("n")]
        [TestCase("o")]
        [TestCase("p")]
        [TestCase("q")]
        [TestCase("r")]
        [TestCase("s")]
        [TestCase("t")]
        [TestCase("u")]
        [TestCase("v")]
        [TestCase("w")]
        [TestCase("x")]
        [TestCase("y")]
        [TestCase("z")]
        #endregion
        public void TestListenForCommand_AreEqual(string input)
        {
            Dictionary<string, Func<bool>> cd = CommandManager.Instance.getCommandDictionary();
            Func<bool> actual = CommandManager.Instance.Listen(input);
            Assert.AreEqual(cd[input], actual);
        }



    }
}

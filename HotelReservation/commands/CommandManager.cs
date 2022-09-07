using System;
using System.Collections.Generic;
using HotelReservation;

namespace HotelReservation.commands
{
    public class CommandManager : ICommandListener
    {
        private string input; // user keyboard input

        protected Dictionary<string, Func<bool>> commandDictionary; // map commands to actions

        Func<bool>[] actionArr = new Func<bool>[26];

        private static CommandManager instance = null;

        public CommandManager()
        {
            commandDictionary = new Dictionary<string, Func<bool>>();
            PopulateActionList();
            PopulateCommandDictionary();
        }

        public static CommandManager Instance
        {
            get
            {
                if (instance == null) instance = new CommandManager();
                return instance;
            }
        }

        public Dictionary<string, Func<bool>> getCommandDictionary()
        {
            return commandDictionary;
        }

        private void PopulateActionList()
        {
            #region Populate Action List
            actionArr[0] = A;
            actionArr[1] = B;
            actionArr[2] = C;
            actionArr[3] = D;
            actionArr[4] = E;
            actionArr[5] = F;
            actionArr[6] = G;
            actionArr[7] = H;
            actionArr[8] = I;
            actionArr[9] = J;
            actionArr[10] = K;
            actionArr[11] = L;
            actionArr[12] = M;
            actionArr[13] = N;
            actionArr[14] = O;
            actionArr[15] = P;
            actionArr[16] = Q;
            actionArr[17] = R;
            actionArr[18] = S;
            actionArr[19] = T;
            actionArr[20] = U;
            actionArr[21] = V;
            actionArr[22] = W;
            actionArr[23] = X;
            actionArr[24] = Y;
            actionArr[25] = Z;

            #endregion
        }

        public void PopulateCommandDictionary()
        {
            int i = 0;
            for(char c = 'a'; c <= 'z'; c++)
            {
                commandDictionary.Add(c.ToString(), actionArr[i]);
                i++;
            }
        }

        public Func<bool> Listen(string testInput = "")
        {
            Console.WriteLine("Enter a command");

            if (testInput.Length > 0) // if Listen() is called in a test class
                input = testInput;
            else
                input = Console.ReadLine().ToLower();
            foreach(string c in commandDictionary.Keys)
            {
                if (c.Equals(input))
                {
                    // perform relevant action
                    Func<bool> action = commandDictionary[input];
                    action();
                }
            }
            Console.WriteLine("re: " + (CommandManager.Instance.A == commandDictionary[input]));
            return commandDictionary[input];
        }

        public virtual bool A()
        {
            return true;
        }

        public virtual bool B()
        {
            return true;
        }

        public virtual bool C()
        {
            return true;
        }

        public bool D()
        {
            return true;
        }

        public bool E()
        {
            return true;
        }

        public bool F()
        {
            return true;
        }

        public bool G()
        {
            return true;
        }

        public bool H()
        {
            return true;
        }

        public bool I()
        {
            return true;
        }

        public bool J()
        {
            return true;
        }

        public bool K()
        {
            return true;
        }

        public virtual bool L()
        {
            return true;
        }

        public bool M()
        {
            return true;
        }

        public bool N()
        {
            return true;
        }

        public bool O()
        {
            return true;
        }

        public bool P()
        {
            return true;
        }

        public bool Q()
        {
            StartApp.ISRUNNING = false;
            return true;
        }

        public bool R()
        {
            return true;
        }

        public bool S()
        {
            return true;
        }

        public bool T()
        {
            return true;
        }

        public bool U()
        {
            return true;
        }

        public bool V()
        {
            return true;
        }

        public bool W()
        {
            return true;
        }

        public bool X()
        {
            return true;
        }

        public bool Y()
        {
            return true;
        }

        public bool Z()
        {
            return true;
        }
    }
}

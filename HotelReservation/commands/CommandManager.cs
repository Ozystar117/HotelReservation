using System;
using System.Collections.Generic;
using HotelReservation;

namespace HotelReservation.commands
{
    public class CommandManager : ICommandListener
    {
        private string input; // user keyboard input

        Dictionary<string, Func<bool>> commandDictionary; // map commands to actions

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

        private void PopulateCommandDictionary()
        {
            int i = 0;
            for(char c = 'a'; c <= 'z'; c++)
            {
                commandDictionary.Add(c.ToString(), actionArr[i]);
                i++;
            }
        }

        public void Listen(string testInput = "")
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
        }

        public bool A()
        {
            throw new NotImplementedException();
        }

        public bool B()
        {
            throw new NotImplementedException();
        }

        public bool C()
        {
            throw new NotImplementedException();
        }

        public bool D()
        {
            throw new NotImplementedException();
        }

        public bool E()
        {
            throw new NotImplementedException();
        }

        public bool F()
        {
            throw new NotImplementedException();
        }

        public bool G()
        {
            throw new NotImplementedException();
        }

        public bool H()
        {
            throw new NotImplementedException();
        }

        public bool I()
        {
            throw new NotImplementedException();
        }

        public bool J()
        {
            throw new NotImplementedException();
        }

        public bool K()
        {
            throw new NotImplementedException();
        }

        public virtual bool L()
        {
            return true;
        }

        public bool M()
        {
            throw new NotImplementedException();
        }

        public bool N()
        {
            throw new NotImplementedException();
        }

        public bool O()
        {
            throw new NotImplementedException();
        }

        public bool P()
        {
            throw new NotImplementedException();
        }

        public bool Q()
        {
            StartApp.ISRUNNING = false;
            return true;
        }

        public bool R()
        {
            throw new NotImplementedException();
        }

        public bool S()
        {
            throw new NotImplementedException();
        }

        public bool T()
        {
            throw new NotImplementedException();
        }

        public bool U()
        {
            throw new NotImplementedException();
        }

        public bool V()
        {
            throw new NotImplementedException();
        }

        public bool W()
        {
            throw new NotImplementedException();
        }

        public bool X()
        {
            throw new NotImplementedException();
        }

        public bool Y()
        {
            throw new NotImplementedException();
        }

        public bool Z()
        {
            throw new NotImplementedException();
        }
    }
}

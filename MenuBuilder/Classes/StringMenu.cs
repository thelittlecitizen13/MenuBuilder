﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class StringMenu : Menu
    {
        public Dictionary<string, IAction> ActionOptions { get; set; }

        public void Run()
        {
            base.Run();
        }


        public StringMenu(Dictionary<string,IAction> actions, string name, string mainOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
        }

    }
}

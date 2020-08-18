using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class NumericMenu : Menu 
    {
        public Dictionary<int, IAction> ActionOptions { get; set; }
        

        public void Run()
        {
            base.Run();
        }

        
        public NumericMenu(Dictionary<int, IAction> actions, string name, string mainOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
        }

        
    }
}

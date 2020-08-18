using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class NumericMenu : Menu <int>
    {
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
            BuildMenu(true);
        }

        
    }
}

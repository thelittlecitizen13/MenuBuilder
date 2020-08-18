using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class StringMenu : Menu<string>
    {
        

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
            BuildMenu(false);
        }

    }
}

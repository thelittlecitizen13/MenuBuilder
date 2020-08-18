using MenuBuilder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class NumericMenu : Menu <int>
    {
        public void Run()
        {
            int choice = 0;
            do
            {
                base.Run();
                Console.Write("Your choice: ");
                choice = InputHandler.ReadIntParser();
                if (IsChoiceValid(choice))
                    ActionOptions[choice].Action();
                else
                    Console.WriteLine("Choice not valid");
            }
            while (choice != ActionOptions.Keys.Last());
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

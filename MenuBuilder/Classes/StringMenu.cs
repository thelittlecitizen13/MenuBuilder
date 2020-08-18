using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class StringMenu : Menu<string>
    { 
        public void Run()
        {
            string choice = "";
            do
            {
                base.Run();
                choice = GetValidInput();
            }
            while (choice != ActionOptions.Keys.Last());
        }


        public StringMenu(Dictionary<string,IAction> actions, string name, string mainOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
            BuildMenu(false);
        }

        private string GetValidInput()
        {
            string choice;
            while (true)
            {
                Console.Write("Your choice: ");
                choice = Console.ReadLine();
                if (IsChoiceValid(choice))
                {
                    ActionOptions[choice].Action();
                    return choice;
                }
                else
                    Console.WriteLine("Choice not valid");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class StringMenu : Menu<string>
    { 
        public new void Run()
        {
            string choice = "";
            do
            {
                base.Run();
                choice = GetValidInput();
                try
                {
                    ActionOptions[choice].RunAction();
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Action is not available at the moment");
                }
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadLine();
            }
            while (choice != ActionOptions.Keys.Last());
        }


        public StringMenu(Dictionary<string,Option> actions, string name, string mainOutput, bool addActionDescriptionOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
            AppendExitOption();
            BuildMenu(addActionDescriptionOutput);
            
        }

        private string GetValidInput()
        {
            string choice;
            while (true)
            {
                Console.Write("Your choice (Case Sensitive!): ");
                choice = Console.ReadLine();
                if (IsChoiceValid(choice))
                {
                    return choice;
                }
                else
                {
                    InputHandler.PrintBlankLines(2);
                    Console.WriteLine("Choice not valid");
                    InputHandler.PrintBlankLines(2);
                }
            }
        }

        protected override void AppendExitOption()
        {
            ActionOptions.Add("Exit", new Option(Actions.DoNothing, "Exit / Back"));
        }

    }
}

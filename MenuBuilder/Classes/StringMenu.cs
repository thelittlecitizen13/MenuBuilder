using MenuBuilder.Classes;
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
                choice = MenuInputHandler.GetStringValidInput(this);
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

        

        protected override void AppendExitOption()
        {
            ActionOptions.Add("Exit", new Option(Actions.DoNothing, "Exit / Back"));
        }

    }
}

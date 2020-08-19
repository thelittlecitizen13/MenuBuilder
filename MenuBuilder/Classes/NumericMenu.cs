using MenuBuilder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder
{
    public class NumericMenu : Menu <int>
    {
        public new void Run()
        {
            int choice = 0;
            do
            {
                base.Run();
                choice = MenuInputHandler.GetNumericValidInput(this);
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
           
        
        public NumericMenu(Dictionary<int, Option> actions, string name, string mainOutput, bool addActionDescriptionOutput)
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
            int lastKeyValue = ActionOptions.Keys.Last();
            lastKeyValue++;
            ActionOptions.Add(lastKeyValue, new Option(Actions.DoNothing, "Exit / Back"));
        }
    }
}

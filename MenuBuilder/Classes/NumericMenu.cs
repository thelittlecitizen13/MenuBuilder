﻿using System;
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
                choice = GetValidInput();
                try
                {
                    ActionOptions[choice].Action();
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
           
        
        public NumericMenu(Dictionary<int, IAction> actions, string name, string mainOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
            AppendExitOption();
            BuildMenu(true);
            
        }

        public int GetValidInput()
        {
            int choice;
            while(true)
            {
                Console.Write("Your choice: ");
                choice = InputHandler.ReadIntParser();
                if (IsChoiceValid(choice))
                    return choice;
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
            int lastKeyValue = ActionOptions.Keys.Last();
            lastKeyValue++;
            ActionOptions.Add(lastKeyValue, new ExitAction());
        }
    }
}

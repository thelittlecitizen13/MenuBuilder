using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace MenuBuilder
{
    public abstract class Menu<T> : IMenu where T : IConvertible
    {
        public Dictionary<T, IAction> ActionOptions { get; set; }
        public StringBuilder MenuDisplay { get; set; }
        public string MenuName { get; set; }
        public string MainOutput { get; set; }

        

        public virtual void Run()
        {
            Console.Clear();
            if (!IsMenuBuilt())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Menu ${MenuName} - No menu to show");
                Console.ResetColor();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            ShowMenu();
            Console.ResetColor();
        }

        public void ShowMenu()
        {
            Console.WriteLine(MenuDisplay.ToString());
        }
        protected bool IsMenuBuilt()
        {
            return !string.IsNullOrEmpty(Convert.ToString(MenuDisplay)) || ActionOptions.Count == 0;
        }
        protected void BuildMenu(bool addActionDescriptionOutput)
        {
            
            if (ActionOptions.Count == 0)
            {
                Console.WriteLine("Cant build the menu - Actions dictionary is empty");
                return;
            }
            StringBuilder tempMenu = new StringBuilder();
            tempMenu.AppendLine($"-------- {MenuName.ToUpper()} --------");
            tempMenu.AppendLine();
            tempMenu.AppendLine($"---{MainOutput}---");
            tempMenu.AppendLine();
            foreach (T option in ActionOptions.Keys)
            {
                string line = option.ToString();
                if (addActionDescriptionOutput)
                    line += " - " + ActionOptions[option].actionDescriptionOutput;
                tempMenu.AppendLine(line);
            }
            tempMenu.AppendLine("==================================");
            MenuDisplay = tempMenu;
        }

        public bool IsChoiceValid(T choice)
        {
            return ActionOptions.ContainsKey(choice);
        }

        protected abstract void AppendExitOption();

        
    }
}

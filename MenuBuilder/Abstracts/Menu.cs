using System;
using System.Collections.Generic;
using System.Text;


namespace MenuBuilder
{
    public abstract class Menu<T> where T : IConvertible
    {
        public Dictionary<T, IAction> ActionOptions { get; set; }
        public StringBuilder MenuDisplay { get; set; }
        public string MenuName { get; set; }
        public string MainOutput { get; set; }

        public void Run()
        {
            if (!IsMenuBuilt())
            {
                Console.WriteLine($"Menu ${MenuName} - No menu to show");
                return;
            }
            ShowMenu();
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
            MenuDisplay.AppendLine(MainOutput);
            if (ActionOptions.Count == 0)
            {
                Console.WriteLine("Cant build the menu - Actions dictionary is empty");
                return;
            }
            StringBuilder tempMenu = new StringBuilder(MenuName);
            tempMenu.AppendLine(MainOutput);
            foreach (T option in ActionOptions.Keys)
            {
                string line = option.ToString();
                if (addActionDescriptionOutput)
                    line += " - " + ActionOptions[option].actionDescriptionOutput;
                tempMenu.AppendLine(line);
            }

            MenuDisplay = tempMenu;
        }

    }
}

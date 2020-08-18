using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Classes
{
    class StringMenu : IMenu
    {
        public Dictionary<string, IAction> ActionOptions { get; set; }
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


        public StringMenu(Dictionary<string,IAction> actions, string name, string mainOutput)
        {
            ActionOptions = actions;
            MenuDisplay = new StringBuilder();
            MenuName = name;
            MainOutput = mainOutput;
        }

        private bool IsMenuBuilt()
        {
            return ! string.IsNullOrEmpty(Convert.ToString(MenuDisplay));
        }
    }
}

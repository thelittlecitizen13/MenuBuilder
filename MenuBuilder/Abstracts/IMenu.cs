using System;
using System.Collections.Generic;
using System.Text;


namespace MenuBuilder
{
    public abstract class Menu
    {
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
        private bool IsMenuBuilt()
        {
            return !string.IsNullOrEmpty(Convert.ToString(MenuDisplay));
        }
    }
}

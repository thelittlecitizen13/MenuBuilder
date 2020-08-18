using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class ShowNextMenuAction : IAction
    {
        public string actionDescriptionOutput { get; set; }

        public Menu<string> nextMenu { get; set; }
        public void Action()
        {
            Console.WriteLine("Hi Assa");
        }
        public ShowNextMenuAction(Menu<string> next, string output)
        {
            actionDescriptionOutput = output;
            nextMenu = next;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class ShowNextMenuAction : IAction 
    {
        public string actionDescriptionOutput { get; set; }

        public NumericMenu nextMenu { get; set; }
        public void Action()
        {
            nextMenu.Run();
        }
        public ShowNextMenuAction(NumericMenu next, string output)
        {
            actionDescriptionOutput = output;
            nextMenu = next;
        }

    }
}

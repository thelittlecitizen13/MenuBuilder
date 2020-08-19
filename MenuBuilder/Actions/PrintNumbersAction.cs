using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class PrintNumbersAction : IAction
    {
        public string actionDescriptionOutput => "Print Random Numbers";

        public void Action()
        {
            Console.WriteLine(String.Join(", ", InputHandler.GetNumericListOfInputs(3, "Enter random inputs")));
        }
    }
}

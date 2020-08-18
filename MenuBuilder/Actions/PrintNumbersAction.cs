using MenuBuilder.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class PrintNumbersAction : IAction
    {
        public string actionDescriptionOutput => "Print Random Numbers";

        public void Action()
        {
            Console.WriteLine(String.Join(", ", InputHandler.GetNumericInputs(3, "Enter random inputs")));
        }
    }
}

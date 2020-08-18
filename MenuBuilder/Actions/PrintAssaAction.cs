using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class PrintAssaAction : IAction
    {
        public string actionDescriptionOutput => "Print Assa";

        public void Action()
        {
            Console.WriteLine("Hi Assa");
        }
    }
}

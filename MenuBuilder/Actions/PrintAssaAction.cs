using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class PrintAssaAction : IAction
    {
        public string actionDescriptionOutput => "Print Assa";

        public void Action()
        {
            Console.WriteLine("Hi Assa");
        }
    }
}

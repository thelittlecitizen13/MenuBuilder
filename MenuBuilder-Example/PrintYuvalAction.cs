using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace MenuBuilder_Example
{
    public class PrintYuvalAction : IAction
    {
        public string actionDescriptionOutput => "Print Yuval";

        public void Action()
        {
            Console.WriteLine("Chief Yuval");
        }
    }
}

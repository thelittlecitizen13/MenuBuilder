using MenuBuilder.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class PrintNameAction : IAction
    {
        public string actionDescriptionOutput => "Print a name";

        public void Action()
        {
            Console.WriteLine("Hi " + Console.ReadLine());
        }
    }
}

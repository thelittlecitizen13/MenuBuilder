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
            Console.Write("Please write a name to say 'Hi' to");
            Console.WriteLine("Hi " + Console.ReadLine());
        }
    }
}

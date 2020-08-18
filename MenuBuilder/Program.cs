using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IAction> options = new Dictionary<string, IAction>()
            {
                {"Assa" , new PrintAssaAction() } , {"Name" , new PrintNameAction() } , {"Numbers" , new PrintNumbersAction() }
            };
            StringMenu numMenu = new StringMenu(options, "My test menu", "Please choose one of the following:");
            numMenu.Run();
        }
    }
}

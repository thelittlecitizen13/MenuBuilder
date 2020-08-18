using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, IAction> numericOptions = new Dictionary<int, IAction>()
            {
                {1 , new PrintAssaAction() } , {2 , new PrintNameAction() } , {3 , new PrintNumbersAction() }
            };
            NumericMenu numMenu = new NumericMenu(numericOptions, "My test menu", "Please choose one of the following:");

            Dictionary<string, IAction> stringOptions = new Dictionary<string, IAction>()
            {
                {"Assa" , new PrintAssaAction() } , {"Name" , new PrintNameAction() } , {"Numbers" , new PrintNumbersAction() }, { "Numeric Menu", new ShowNextMenuAction(numMenu, "Show numeric menu")}
            };
            StringMenu strMenu = new StringMenu(stringOptions, "My test menu", "Please choose one of the following:");

            
            strMenu.Run();
        }
    }
}

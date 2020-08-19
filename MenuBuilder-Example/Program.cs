using System;
using System.Collections.Generic;
using MenuBuilder;

namespace MenuBuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, IAction> numericOptions = new Dictionary<int, IAction>()
            {
                {1 , new PrintAssaAction() } , {2 , new PrintNameAction() } , {3 , new PrintNumbersAction() }
            };
            NumericMenu numMenu = new NumericMenu(numericOptions, "My test menu", "Please choose one of the following:", true);

            Dictionary<string, IAction> stringOptions = new Dictionary<string, IAction>()
            {
                {"Yuval" , new PrintYuvalAction() } , {"Name" , new PrintNameAction() } , {"Numbers" , new PrintNumbersAction() }, { "NumMenu", new ShowNextMenuAction(numMenu, "Show numeric menu")}
            };
            StringMenu strMenu = new StringMenu(stringOptions, "My test menu", "Please choose one of the following:", true);


            strMenu.Run();
        }
    }
}

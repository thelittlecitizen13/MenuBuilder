using System;
using System.Collections.Generic;
using MenuBuilder;

namespace MenuBuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Option> numericOptions = new Dictionary<int, Option>()
            {
                {1 , new Option(Actions.PrintAssa, "Print Assa") } , {2 ,new Option(Actions.PrintName, "Print a Name") } , {3 , new Option(Actions.PrintNumbers, "Print Your Numbers") }
            };
            NumericMenu numMenu = new NumericMenu(numericOptions, "My test menu", "Please choose one of the following:", true);

            Dictionary<string, Option> stringOptions = new Dictionary<string, Option>()
            {
                {"Yuval" , new Option(Actions.PrintYuval, "Print Yuval") } , {"Name" , new Option(Actions.PrintName, "Print a Name") } , {"Numbers" , new Option(Actions.PrintNumbers, "Print Your Numbers") }, { "NumMenu", new Option(numMenu.Run, "Show numeric menu")}
            };
            StringMenu strMenu = new StringMenu(stringOptions, "My test menu", "Please choose one of the following:", true);


            strMenu.Run();
        }
    }
}

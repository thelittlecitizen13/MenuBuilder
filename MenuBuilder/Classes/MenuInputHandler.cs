using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Classes
{
    public static class MenuInputHandler
    {
        public static string GetStringValidInput(Menu<string> stringMenu)
        {
            string choice;
            while (true)
            {
                Console.Write("Your choice (Case Sensitive!): ");
                choice = Console.ReadLine();
                if (stringMenu.IsChoiceValid(choice))
                {
                    return choice;
                }
                else
                {
                    FunctionInputHandler.PrintBlankLines(2);
                    Console.WriteLine("Choice not valid");
                    FunctionInputHandler.PrintBlankLines(2);
                }
            }
        }

        public static int GetNumericValidInput(Menu<int> numericMenu)
        {
            int choice;
            while (true)
            {
                Console.Write("Your choice: ");
                choice = FunctionInputHandler.ReadIntParser();
                if (numericMenu.IsChoiceValid(choice))
                    return choice;
                else
                {
                    FunctionInputHandler.PrintBlankLines(2);
                    Console.WriteLine("Choice not valid");
                    FunctionInputHandler.PrintBlankLines(2);

                }
            }
        }
    }
}

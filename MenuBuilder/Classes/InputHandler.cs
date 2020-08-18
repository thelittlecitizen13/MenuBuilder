using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Classes
{
    class InputHandler
    {
        public static int ReadIntParser()
        {
            int choice = 0;
            while (choice == 0)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input, please try again");
                }
            }
            return choice;
        }



        public static List<string> GetStringInputs (int numberOfInputs, string output)
        {
            Console.WriteLine(output);
            List<string> inputs = new List<string>();
            int countOfGoodInputs = 0;
            while (countOfGoodInputs != numberOfInputs)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    inputs.Add(input);
                else
                    Console.WriteLine("Wrong input");
            }
            return inputs;
        }
        public static List<int> GetNumericInputs(int numberOfInputs, string output)
        {
            Console.WriteLine(output);
            List<int> inputs = new List<int>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                int input = ReadIntParser();
                inputs.Add(input);
            }
            return inputs;
        }
    }
}

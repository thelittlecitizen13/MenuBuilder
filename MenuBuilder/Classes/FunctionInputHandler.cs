using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class FunctionInputHandler
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
                    Console.WriteLine("Wrong input, please try again:");
                }
            }
            return choice;
        }



        public static List<string> GetStringListOfInputs (int numberOfInputs, string output)
        {
            Console.WriteLine(output);
            List<string> inputs = new List<string>();
            int countOfGoodInputs = 0;
            Console.WriteLine("End line after every input!");
            PrintBlankLines(2);
            
            while (countOfGoodInputs != numberOfInputs)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    inputs.Add(input);
                else
                    Console.WriteLine("Wrong input, try again.");
            }
            return inputs;
        }
        public static List<int> GetNumericListOfInputs(int numberOfInputs, string output)
        {
            Console.WriteLine(output);
            List<int> inputs = new List<int>();
            Console.WriteLine("End line after every input!");
            PrintBlankLines(2);
            for (int i = 0; i < numberOfInputs; i++)
            {
                int input = ReadIntParser();
                inputs.Add(input);
            }
            return inputs;
        }

        public static void PrintBlankLines(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
            }
        }


    }
}

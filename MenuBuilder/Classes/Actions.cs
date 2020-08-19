using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public static class Actions
    {
        public static void PrintNumbers()
        {
            Console.WriteLine(String.Join(", ", FunctionInputHandler.GetNumericListOfInputs(3, "Enter random inputs")));
        }

        public static void PrintName()
        {
            Console.Write("Please write a name to say 'Hi' to");
            Console.WriteLine("Hi " + Console.ReadLine());
        }

        public static void PrintAssa()
        {
            Console.WriteLine("Hi Assa");
        }

        public static void PrintYuval()
        {
            Console.WriteLine("Chief Yuval");
        }

        public static void DoNothing()
        {

        }
    }
}

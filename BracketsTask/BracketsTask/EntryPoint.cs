using System;

namespace BracketsTask
{
    /// <summary>
    /// Main class of program which checks 
    /// that the brackets are correctly positioned in the input line.
    /// </summary>
    class EntryPoint
    {
        private const string INPUT_STRING = "Enter your string:";
        private const string RIGHT_STRING = "Your string is valid.";
        private const string FALSE_STRING = "Your string is not valid.";
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while(continueProgram)
            {
                try
                {
                    Console.WriteLine(INPUT_STRING);
                    string stringWithBrackets = Console.ReadLine();
                    Brackets brackets = new Brackets();
                    if(brackets.IsValid(stringWithBrackets))
                    {
                        Console.WriteLine(RIGHT_STRING);
                    }
                    else
                    {
                        Console.WriteLine(FALSE_STRING);
                    }                   
                    continueProgram = false;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
        }
    }
}

using System;

namespace DEV_4
{
   public class OperationWithConsole
    {
        private const string ENTER = "Enter the element of the sequence of integers ";
        private const string POSITIVE_RESULT = "\n This sequence is non - decreasing.";
        private const string NEGATIVE_RESULT = "\n This sequence is not non - decreasing.";
        private const string CHOISE = "Press 'Enter' to continue or 'n' to exit";
    public bool CheckInputNumbers ()
    {

        Console.WriteLine(ENTER);
        SequenseOfNumbers sequenceOfNumber = new SequenseOfNumbers();
        int count = 1;
        string previous = int.MinValue.ToString(), next;
        bool verification = true;
        while (verification)
        {
           if (count != 1)
           {
               Console.WriteLine(CHOISE);
               if (Console.ReadKey().Key == ConsoleKey.N)
               {
                   break;
               }
           }
           Console.WriteLine("element " + count);         
           next = Console.ReadLine();
           int[] elements = sequenceOfNumber.ConvertToInt(previous, next);
           verification = sequenceOfNumber.IsFulfilmentNonDecreasing(elements);
           previous = next;
           count++;         
        }
        return verification;
    }

    public void OutputOfResult(bool result)
    {
        if (result)
        {
            
            Console.WriteLine(POSITIVE_RESULT);
        }
        else
        {
            Console.WriteLine(NEGATIVE_RESULT);
        }
        Console.ReadKey();
    }
        
    }
}

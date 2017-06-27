using System;


namespace DEV_4
{
    class EntryPoint
    {
        static void Main()
        {
           bool duration = true;
           while (duration)
           {
               try
               {
                   Console.WriteLine("Enter the sequence of integers: ");
                   string enteredString = Console.ReadLine();
                   SequenseOfNumbers sequenceOfNumbers = new SequenseOfNumbers();
                   int[] sequence = sequenceOfNumbers.ConvertToInt(enteredString);
                   bool result = sequenceOfNumbers.IsSequenceNondecreasing(sequence);
                   sequenceOfNumbers.OutputOfResult(result);
               }
               catch (FormatException)
               {
                   Console.WriteLine("Enter integers!!Try again: \n");
                   continue;
               }
               duration = false;
           }
        }

    }
}

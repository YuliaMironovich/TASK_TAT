using System;


namespace DEV_4
{
    class EntryPoint
    {
        static void Main(string [] args)
        {
           bool duration = true;
           while (duration)
           {
               try
               {
                   if (args.Length == 0)
                   {
                       Console.WriteLine("You did not enter values in the command line. Enter the sequence of integers: ");
                       string enteredString = Console.ReadLine();
                       string[] stringSequence = enteredString.Split(' ');
                       SequenseOfNumbers sequenceOfNumbers = new SequenseOfNumbers();
                       int[] sequence = sequenceOfNumbers.ConvertToInt(stringSequence);
                       bool result = sequenceOfNumbers.IsSequenceNondecreasing(sequence);
                       sequenceOfNumbers.OutputOfResult(result);
                   }
                   else
                   {
                       SequenseOfNumbers sequenceOfNumbers = new SequenseOfNumbers();
                       int[] sequence = sequenceOfNumbers.ConvertToInt(args);
                       bool result = sequenceOfNumbers.IsSequenceNondecreasing(sequence);
                       sequenceOfNumbers.OutputOfResult(result);   
                   }
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

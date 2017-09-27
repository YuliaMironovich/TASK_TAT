using System;


namespace DEV_4
{
    class EntryPoint
    {
        private const string ERROR = ("Enter correct data! \n");
        static void Main(string [] args)
        {
           bool duration = true;
           while (duration)
           {
               try
               {
                   SequenseOfNumbers sequenceOfNumbers = new SequenseOfNumbers();
                   sequenceOfNumbers.IsNonDecreasing(args);
               }
               catch (FormatException)
               {
                   Console.WriteLine(ERROR);
                   continue;
               }
               duration = false;
           }
        }

    }
}

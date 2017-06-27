using System;

namespace DEV_4
{
   public class SequenseOfNumbers
    {
       public int [] ConvertToInt(string enteredString)
       {
          string[] stringSequence = enteredString.Split(' ');
          int length = stringSequence.Length; 
          int [] sequence = new int [length];
          for (int i = 0; i < length; i++)
          {
              sequence[i] = int.Parse(stringSequence[i]);
          }
          return sequence; 
       }
        public bool CheckOfNondecreasing(int[] sequence)
        {
            bool verification = false;
            for (int i = 0; i < sequence.Length - 1 ; i++)
            {
                int previous = sequence[i];
                int next = sequence[i + 1];
                if (previous <= next)
                {
                    verification = true;
                }
                else
                {
                    verification = false;
                    break;
                }
            }
            return verification;
        }
   public void OutputOfResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("This sequence is non - decreasing.");
            }
            else
            {
                Console.WriteLine("This sequence is not non - decreasing.");
            }
            Console.ReadKey();
        }

    }
}

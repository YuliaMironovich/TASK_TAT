using System;

namespace DEV_4
{
   public class SequenseOfNumbers
    {
       public int[] ConvertToInt(string[] stringSequence)
       {
          int[] sequence = new int[stringSequence.Length];
          for (int i = 0; i < stringSequence.Length; i++)
          {
              sequence[i] = int.Parse(stringSequence[i]);
          }
          return sequence; 
       }
        public bool IsSequenceNondecreasing(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1 ; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    return false;
                }  
            }
            return true;
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

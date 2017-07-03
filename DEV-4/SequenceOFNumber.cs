using System;

namespace DEV_4
{
   public class SequenseOfNumbers
    {
       public int[] ConvertToInt(string previous, string next)
       {
          int[] pair = new int[2];
          pair[0] = int.Parse(previous);
          pair[1] = int.Parse(next);
          return pair; 
       }

        public bool IsFulfilmentNonDecreasing(int[] sequence)
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


       public void IsNonDecreasing(string [] args)
        {       
            bool verification = true;
            int count = 0;
            OperationWithConsole operationWithConsole = new OperationWithConsole();
            if (args.Length != 0)
            { 
                while(verification && (count < (args.Length - 1)))
                {
                  int[] elements =  ConvertToInt(args[count], args[count + 1]);
                  verification = IsFulfilmentNonDecreasing(elements);
                  count++;
                }
                operationWithConsole.OutputOfResult(verification);
            }
            else
            {
               verification = operationWithConsole.CheckInputNumbers();
               operationWithConsole.OutputOfResult(verification);
            }                
        }
    }
}

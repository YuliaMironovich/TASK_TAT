using System;


namespace DEV_9
{
    class CharArray
    {
        public char[] ReplaceSymbols(char[] first, char[] second)
        {
                Random rnd1 = new Random();
                Random rnd2 = new Random(); 
                int firstNumberForReplacing = rnd1.Next(1, first.Length);
                int secondNumberForReplacing = rnd2.Next(1, second.Length);
                int firstOrigin = rnd1.Next(0, first.Length - firstNumberForReplacing);
                int secondOrigin = rnd2.Next(0, second.Length - secondNumberForReplacing);
                int size = second.Length - secondNumberForReplacing + firstNumberForReplacing;
                char[] result = new char[size];
                for (int i = 0; i < secondOrigin; i++)
                {
                    result[i] = second[i];
                }
                int j = firstOrigin;
                for (int i = secondOrigin; i < secondOrigin + firstNumberForReplacing; i++)
                {
                    result[i] = first[j];
                    j++;
                }
                j = secondOrigin + secondNumberForReplacing;
                for (int i = secondOrigin + firstNumberForReplacing; i < size; i++ )
                {
                    result[i] = second[j];
                    j++;
                }
                return result;           
        }
        
        public void Output(char[] array)
        {
            foreach (char element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
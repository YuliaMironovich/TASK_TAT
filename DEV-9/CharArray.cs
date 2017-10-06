using System;
using System.Text;

namespace DEV_9
{
    class CharArray
    {
        public string ReplaceSymbols(char[] first, char[] second)
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int firstNumberForReplacing = rnd1.Next(1, first.Length);
            int secondNumberForReplacing = rnd2.Next(1, second.Length);
            int firstOrigin = rnd1.Next(0, first.Length - firstNumberForReplacing);
            int secondOrigin = rnd2.Next(0, second.Length - secondNumberForReplacing);
            string firstPartOfRow = new string(second, 0, secondOrigin);
            string secondPartOfRow = new string(first, firstOrigin, firstNumberForReplacing);
            int startIndex = secondOrigin + secondNumberForReplacing;
            int number = second.Length - (secondOrigin + secondNumberForReplacing);
            string thirdPartOfRow = new string(second, startIndex, number);
            StringBuilder result = new StringBuilder();
            result.Append(firstPartOfRow);
            result.Append(secondPartOfRow);
            result.Append(thirdPartOfRow);
            return result.ToString();
        }
        
        public void Output(char[] array)
        {
            string row = new string(array);
            Console.WriteLine(row);
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketsTask
{
    /// <summary>
    /// Class contain information about brackets.
    /// Contains all type of brackets and methods which check string for the validity.
    /// </summary>
    public class Brackets
    {
        public char[] charBrackets = { '(', '{', '[', ')', '}', ']' };
        public string stringOpenBrackets = "({[" ;
        public string stringCloseBrackets = ")}]";
        Stack<char> brackets = new Stack<char>();

        /// <summary>
        /// This method sums up the checks for the validity of the entered string.
        /// </summary>
        /// <param name="inputString">Input string from the console.</param>
        /// <returns>True if the string is valid. </returns>
        public bool IsValid(string inputString)
        {
            bool validation = true;
            if (!IsContainBrackets(inputString))
            {
                return validation = false;
            }
            char[] inputLine = inputString.ToCharArray();
            for(int i = 0; i < inputLine.Length; i++)
            {
                for(int j = 0; j < charBrackets.Length; j++)
                {
                    if (inputLine[i] == charBrackets[j] && !IsValidBracketArrangement(inputLine[i]))
                    {
                        return validation = false;
                    }
                }
            }
            return validation;
        }

        /// <summary>
        /// Method checks for the correct sequence of the brackets.
        /// If an opening bracket occurs, this bracket add to the stack.
        /// If an opening bracket accurs, this brackets checks for the the corresponding open bracket.
        /// </summary>
        /// <param name="bracket">Bracket from the input string.</param>
        /// <returns>True if the sequence of brackets correct.</returns>
        private bool IsValidBracketArrangement(char bracket)
        {
            bool validation = true;
            if (stringOpenBrackets.Contains(bracket))
            {
                brackets.Push(bracket);
            }
            else 
            {
                if(IsValidBracketInPair(bracket))
                {
                    brackets.Pop();
                }
                else
                {
                    return validation = false;
                }
            }
            return validation;
        }

        /// <summary>
        /// Method checks close brackets for the the corresponding open bracket.
        /// Correspondence is in array charBrackets, and close bracket correcpond open bracket which index is 3 less.
        /// </summary>
        /// <param name="bracket">Bracket from the input string.</param>
        /// <returns>True if the open bracket is correcpond the close bracket.</returns>
        private bool IsValidBracketInPair(char bracket)
        {
            bool validation = false;
            if (brackets.Peek() == charBrackets[Array.IndexOf(charBrackets, bracket) - 3])
            {
                return validation = true;
            }
            return validation;
        }

        /// <summary>
        /// Method checks string for the contents of brackets in it.
        /// </summary>
        /// <param name="inputLine">Input string.</param>
        /// <returns>True if the string contains the brackets</returns>
        private bool IsContainBrackets(string inputLine)
        {
            bool validation = true;
            int countOfBrackets = 0;
            for (int i = 0; i < inputLine.Length; i++)
            {
                for (int j = 0; j < charBrackets.Length; j++)
                {
                    if (inputLine[i] == charBrackets[j])
                    {
                        countOfBrackets++;
                    }
                }
            }
            if(countOfBrackets == 0)
            {
                return validation = false;
            }
            return validation;
        }
    }
}

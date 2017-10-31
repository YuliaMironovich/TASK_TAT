using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_11
{
    class RomanAlphabet
    {
        //Method which converts from roman letters to cyrilics
        public string ConvertToCyr(AdjacentLetters adjacentLetters, bool ending, ref int checker, char letter)
        {
            switch (adjacentLetters.letter)
            {
                case 'A': return "А";
                case 'B': return "Б";
                case 'C': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker).ToUpper();
                case 'D': return "Д";
                case 'E': return "Е";
                case 'F': return "Ф";
                case 'G': return "Г";
                case 'I': return CheckTheEnding(adjacentLetters, ending, ref checker).ToUpper();
                case 'K': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker).ToUpper();
                case 'L': return "Л";
                case 'M': return "М";
                case 'N': return "Н";
                case 'O': return "О";
                case 'P': return "П";
                case 'R': return "Р";
                case 'S': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker).ToUpper();
                case 'T': return "Т";
                case 'U': return "У";
                case 'V': return "В";
                case 'Y': return CheckDoubleVowel(adjacentLetters, ref checker).ToUpper();
                case 'Z': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker).ToUpper();
                case 'a': return "а";
                case 'b': return "б";
                case 'c': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker);
                case 'd': return "д";
                case 'e': return "е";
                case 'f': return "ф";
                case 'g': return "г";
                case 'i': return CheckTheEnding(adjacentLetters, ending, ref checker);
                case 'k': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker);
                case 'l': return "л";
                case 'm': return "м";
                case 'n': return "н";
                case 'o': return "о";
                case 'p': return "п";
                case 'r': return "р";
                case 's': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker);
                case 't': return "т";
                case 'u': return "у";
                case 'v': return "в";
                case 'y': return CheckDoubleVowel(adjacentLetters, ref checker);
                case 'z': return CheckForDoubleSymbols(adjacentLetters, letter, ref checker);
                default: return letter.ToString();
            }
        }

        //Check if some combinations of letters can convert to cyrylics
        public string CheckForDoubleSymbols(AdjacentLetters adjacentLetters, char letter, ref int cheker)
        {
            if ((adjacentLetters.letter == 'k' && adjacentLetters.nextLetter == 'h') || 
                (adjacentLetters.letter == 'K' && adjacentLetters.nextLetter == 'H'))
            {
                cheker++;
                return "х";
            }
            if ((adjacentLetters.letter == 'k' && adjacentLetters.nextLetter != 'h')||
               (adjacentLetters.letter == 'K' && adjacentLetters.nextLetter != 'H'))
                return "к";
            if ((adjacentLetters.letter == 'z' && adjacentLetters.nextLetter == 'h')||
                (adjacentLetters.letter == 'Z' && adjacentLetters.nextLetter == 'H'))
            {
                cheker++;
                return "ж";
            }
            if ((adjacentLetters.letter == 'z' && adjacentLetters.nextLetter != 'h')||
               (adjacentLetters.letter == 'Z' && adjacentLetters.nextLetter != 'H'))
                return "з";
            if ((adjacentLetters.letter == 'c' && adjacentLetters.nextLetter == 'h')||
                (adjacentLetters.letter == 'C' && adjacentLetters.nextLetter == 'H'))
            {
                cheker++;
                return "ч";
            }
           
            if ((adjacentLetters.letter == 's' && adjacentLetters.nextLetter == 'h' && letter == 'c')||
               (adjacentLetters.letter == 'S' && adjacentLetters.nextLetter == 'H' && letter == 'C'))
            {
                cheker = cheker + 3;
                return "щ";
            }
            if ((adjacentLetters.letter == 's' && adjacentLetters.nextLetter == 'h' && letter != 'c')||
                (adjacentLetters.letter == 'S' && adjacentLetters.nextLetter == 'H' && letter != 'C'))
            {
                cheker++;
                return "ш";
            }
            else
                return "c";
        }

        //Check if the letters are at the end of the word
        public string CheckTheEnding(AdjacentLetters letters, bool ending, ref int checker)
        {
            
            if ((ending && letters.letter == 'i' && letters.nextLetter == 'a')||
                (ending && letters.letter == 'I' && letters.nextLetter == 'A'))
            {
                checker++;
                return "ья";
            }
            if ((ending && letters.letter == 'i' && letters.nextLetter == 'y')||
                (ending && letters.letter == 'I' && letters.nextLetter == 'Y'))
            {
                checker++;
                return "ий";
            }
            else
                return "и";
        }

       // Check situations when two latinic letters can convert as one cyrylics letter
        public string CheckDoubleVowel(AdjacentLetters letters, ref int checker)
        {
            if (letters.nextLetter == 'u' || letters.nextLetter == 'U')
            {
                checker++;
                return "ю";
            }
            if (letters.nextLetter == 'a' || letters.nextLetter == 'A')
            {
                checker++;
                return "я";
            }
            else
                return "й";
        }

    }
}

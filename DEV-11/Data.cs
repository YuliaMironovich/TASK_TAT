using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace DEV_11
{
    class Data
    {
        const string path = @"D:\универ\VS tat\DEV-11\FileWithStrings.txt";
        const string writePath = @"D:\универ\VS tat\DEV-11\FileForWriting.txt";
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] words;
        string[] romanWords;
        bool ending = false;
        int checker = 0;
        List<string> textFromFile = new List<string>();
        List<string> textFromWriteFile = new List<string>();
        CyrillicAlphabets alphabet = new CyrillicAlphabets();
        RomanAlphabet romanAlphabet = new RomanAlphabet();
        AdjacentLetters adjacentLetters = new AdjacentLetters();
        StringBuilder builder = new StringBuilder();
        StringBuilder romanBuilder = new StringBuilder();
        string temp = " "; 

        public void HandleCyrillics()
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.Default))
            {
                while ((temp = streamReader.ReadLine()) != null)
                {
                    textFromFile.Add(temp);
                }
            }
            char[] arrayOfLetters;
            using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
            {
                for (int i = 0; i < textFromFile.Count; i++)
                {
                    words = textFromFile[i].Split(delimiterChars);
                    for (int j = 0; j < words.Length; j++)
                    {
                        arrayOfLetters = words[j].ToCharArray();
                        adjacentLetters.previousLetter = '\0';
                        ending = false;
                        checker = 0;
                        for (int m = 0; m < arrayOfLetters.Length - 1; m++)
                        {
                            adjacentLetters.letter = arrayOfLetters[m];
                            adjacentLetters.nextLetter = arrayOfLetters[m + 1];
                            ending = (m + 2 == arrayOfLetters.Length) ? true : false;
                            builder.Append(alphabet.ConvertToLat(adjacentLetters, ending, ref checker));
                            adjacentLetters.previousLetter = adjacentLetters.letter;
                        }
                        adjacentLetters.letter = adjacentLetters.nextLetter;
                        if (checker == 0)
                            builder.Append(alphabet.ConvertToLat(adjacentLetters, ending, ref checker));

                        sw.Write(builder);
                        sw.Write(' ');
                        Console.Write(builder + " ");
                        builder.Clear();
                    }
                    Console.WriteLine();
                }
            }
        }

        public void HandleRoman()
        {
            using (StreamReader streamReader = new StreamReader(writePath, Encoding.Default))
            {
                while ((temp = streamReader.ReadLine()) != null)
                {
                    textFromWriteFile.Add(temp);
                }
            }
            char[] romanLetters;
            char nextNextLetter = '\0';
            for (int i = 0; i < textFromWriteFile.Count; i++)
            {
                romanWords = textFromWriteFile[i].Split(delimiterChars);
                for (int j = 0; j < romanWords.Length - 1; j++)
                {
                    romanLetters = romanWords[j].ToCharArray();
                    adjacentLetters.previousLetter = '\0';
                    ending = false;
                    checker = 0;
                    for (int m = 0; m < romanLetters.Length - 1; m++)
                    {
                        adjacentLetters.letter = romanLetters[m];
                        adjacentLetters.nextLetter = romanLetters[m + 1];
                        if (m + 2 < romanLetters.Length)
                            nextNextLetter = romanLetters[m + 2];
                        ending = (m + 2 == romanLetters.Length) ? true : false;
                        romanBuilder.Append(romanAlphabet.ConvertToCyr(adjacentLetters, ending, ref checker, nextNextLetter));
                        adjacentLetters.previousLetter = adjacentLetters.letter;
                        m = m + checker;
                    }
                    adjacentLetters.letter = adjacentLetters.nextLetter;
                    if (checker == 0)
                        romanBuilder.Append(romanAlphabet.ConvertToCyr(adjacentLetters, ending, ref checker, nextNextLetter));
                    Console.Write(romanBuilder + " ");
                    romanBuilder.Clear();
                }
                Console.WriteLine();
            }           
        }
    }
}

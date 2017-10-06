using System;
using System.IO;

namespace DEV_9
{
    class EntryPoint
    {
        private const string ERROR = ("Check the data in file for reading!");
        const string path = @"D:\универ\VS tat\DEV-9\FileWithStrings.txt";
        static void Main(string[] args)
        {
            try
            {
                string[] arrayOfLines = new string[2];
                using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < arrayOfLines.Length; i++)
                    {
                        arrayOfLines[i] = streamReader.ReadLine();
                    };
                }
                char[] firstRow = arrayOfLines[0].ToCharArray();
                char[] secondRow = arrayOfLines[1].ToCharArray();
                CharArray array = new CharArray();
                Console.WriteLine("The first row: ");
                array.Output(firstRow);
                Console.WriteLine("The second row: ");
                array.Output(secondRow);
                Console.WriteLine("Result row: ");
                string result = array.ReplaceSymbols(firstRow, secondRow);
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(ERROR);
            }
            Console.ReadKey();
        }

    }
}

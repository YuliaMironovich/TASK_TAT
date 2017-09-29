using System;


namespace DEV_9
{
    class EntryPoint
    {
        private const string ERROR = ("Check the data in file for reading!");
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\универ\VS tat\DEV-9\FileWithStrings.txt";
                const int NUMBER_OF_ROWS = 2;
                File file = new File();
                string[] rows = file.Read(path, NUMBER_OF_ROWS);
                char[] firstRow = rows[0].ToCharArray();
                char[] secondRow = rows[1].ToCharArray();
                CharArray array = new CharArray();
                Console.WriteLine("The first row: ");
                array.Output(firstRow);
                Console.WriteLine("The second row: ");
                array.Output(secondRow);
                Console.WriteLine("Result row: ");
                char[] result = array.ReplaceSymbols(firstRow, secondRow);
                array.Output(result);
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

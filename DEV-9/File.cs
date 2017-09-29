using System;
using System.IO;

namespace DEV_9
{
    public class File
    {
        public string[] Read(string path, int NUMBER_OF_ROWS)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string[] arrayOfLines = new string[NUMBER_OF_ROWS];
                    for (int i = 0; i < NUMBER_OF_ROWS; i++)
                    {
                        arrayOfLines[i] = streamReader.ReadLine();
                    }
                    return arrayOfLines;
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


    }
}

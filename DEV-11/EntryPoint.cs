using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DEV_11
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            const string ERROR = "Check the data in file for reading!";
            Data data = new Data();
            data.HandleCyrillics();
            data.HandleRoman();
            Console.ReadKey();
            
        }
    }
}

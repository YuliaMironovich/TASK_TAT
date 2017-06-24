using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                String numbers = (i % 3==0 ? " 3*" + i / 3 : i.ToString());
                Console.Write(numbers + " ");
            }
            Console.ReadKey();
        }
    }
}

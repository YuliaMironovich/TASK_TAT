using System;


namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                String numbers = ((i % 3 == 0) && (i % 5 != 0) ? "Tutti" : (i % 5 == 0) && (i % 3 != 0) ? "Frutti" : (i % 3 == 0) && (i % 5 == 0) ? "Tutti-Frutti" : i.ToString());
                Console.Write(numbers + " ");
            }
            Console.ReadKey();
        }
    }
}

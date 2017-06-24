using System;


namespace DEV_3
{
    class FibonacciNumber
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int numberToCheck = int.Parse(Console.ReadLine());
                if (numberToCheck < 0)
                {
                    Console.Write("It's a negative number. Try again: ");
                    Main();
                }
                else
                {
                    bool result = false;
                    FibonacciNumber numbersFibonacci = new FibonacciNumber();
                    result = numbersFibonacci.CheckForFibonacciNumber(numberToCheck);
                    if (result || numberToCheck == 0)
                    {
                        Console.WriteLine("This number is Fibonacci number.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("This number is not Fibonacci number.");
                        Console.ReadKey();
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("It's not a number!!\n");
                Console.WriteLine("Error: " + ex.Message + "\n\n");
                Main();
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Invalid value: Please enter a lower number!\n");
                Console.WriteLine("Error: " + ex.Message + "\n\n");
                Main();
            }

        }
        internal bool CheckForFibonacciNumber(int numberToCheck)
        {
            int previos1 = 0;
            int previos2 = 0;
            int subsequent = 1;
            bool verificationForFibonacci = false;

            for (int i = 0; i <= numberToCheck; i++)
            {
                previos1 = previos2;
                previos2 = subsequent;
                subsequent = previos1 + previos2;
                if (numberToCheck == subsequent)
                {
                    verificationForFibonacci = true;
                }
            }

            return verificationForFibonacci;
        }

    }

}

using System;


namespace DEV_3
{
    class Fibonacci_numbers
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number_to_check = int.Parse(Console.ReadLine());
                if (number_to_check < 0)
                 {
                    Console.Write("It's a negative number. Try again: ");
                    Main();
                 }
                else
                {
                    bool result = false;
                    Fibonacci_numbers number = new Fibonacci_numbers();
                    result = number.Check_for_Fibonacci_numbers(number_to_check);
                    if (result || number_to_check == 0)
                    {
                        Console.WriteLine("This number is Fibonucci number.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("This number is not Fibonucci number.");
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

            catch(OverflowException ex)
            {
                Console.WriteLine("Invalid value: Please enter a lower number!\n");
                Console.WriteLine("Error: " + ex.Message + "\n\n");
                Main();
            }

        }
       internal bool Check_for_Fibonacci_numbers(int number_to_check)
        {
            int previos1 = 0;
            int previos2 = 0;
            int subsequent = 1;
            bool verification_for_Fibonacci = false;

            for (int i = 0; i < number_to_check; i++)
            {
                previos1 = previos2;
                previos2 = subsequent;
                subsequent = previos1 + previos2;
                if (number_to_check == subsequent)
                {
                    verification_for_Fibonacci = true;
                }
            }

            return verification_for_Fibonacci;
        }

    }

}

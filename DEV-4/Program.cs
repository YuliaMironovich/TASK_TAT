using System;


namespace DEV_4
{
    class SequenseOfNumbers
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the sequence of integers: ");
                string enteredString = Console.ReadLine();
                string[] sequence = enteredString.Split(' ');
                SequenseOfNumbers sequenceOfNumbers = new SequenseOfNumbers();
                bool result = sequenceOfNumbers.CheckOfNondecreasing(sequence);              
                if (result)
                {
                    Console.WriteLine("This sequence is non - decreasing.");
                }
                else
                {
                    Console.WriteLine("This sequence is not non - decreasing.");
                }
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter integers!!\n");
                Console.WriteLine("Error: " + ex.Message + "\n\n");
                Main();
            }
        }

        private bool CheckOfNondecreasing (string [] sequence)
        {
            bool verification = false;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                int previous = int.Parse(sequence[i]);
                int next = int.Parse(sequence[i + 1]);
                if (previous <= next)
                {
                    verification = true;
                }
                else
                {
                    verification = false;
                    break;
                }
            }
            return verification;
        }
    }
}

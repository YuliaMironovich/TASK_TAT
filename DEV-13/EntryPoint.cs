using System;

namespace DEV_13
{
    class EntryPoint
    {
        private const string MESSAGE = "YOUR DATA IS NOT CORRECT. TRY AGAIN:!";
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while(continueProgram)
            {
                Data data = new Data();
                InitialCondition initialCondition = new InitialCondition();
                initialCondition = data.Input(initialCondition);
                CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
                if (checkerOfCondition.IfCorrect(initialCondition))
                {
                    Context context = new Context(initialCondition.criterion);
                    context.ExecuteOperation(initialCondition);
                    continueProgram = false;     
                }
                else
                {
                    Console.WriteLine(MESSAGE);
                    continue;
                }
                Console.ReadKey();
                Console.ReadKey();
            }  
        }
    }
}

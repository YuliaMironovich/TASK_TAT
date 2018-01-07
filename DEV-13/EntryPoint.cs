using System;
using System.Collections.Generic;

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
                ValidatorOfCondition checkerOfCondition = new ValidatorOfCondition();
                if (checkerOfCondition.IfValid(initialCondition))
                {
                    Context context = new Context(initialCondition.criterion);
                    List<List<int>> result = context.ExecuteOperation(initialCondition);
                    data.Output(result);
                    continueProgram = false;     
                }
                else
                {
                    Console.WriteLine(MESSAGE);
                    continue;
                }
            }  
        }
    }
}

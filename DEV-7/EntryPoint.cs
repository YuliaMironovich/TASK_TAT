using System;

namespace DEV_7
{
    class EntryPoint
    {
        private const string MESSAGE_EXISTANCE = "\nTriangle with such sides does not existance: try again.";
        private const string ERROR = "\nInvalid data format! Try again: ";
        static void Main(string[] args)
        {
          bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    Data data = new Data();
                    Sides sides = new Sides();
                    data.Input(sides);
                    ExistanceTriangle existanceTriangle = new ExistanceTriangle();
                    if (existanceTriangle.IfExistance(sides))
                    {
                        TypeTriangle typeTriangle = new TypeTriangle();
                        TypeTriangle.Types type = typeTriangle.Determine(sides);
                        Builder builder = new Builder();
                        Triangle triangle = builder.BuildTriangle(type, sides);
                        Console.WriteLine(triangle.GetType());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(MESSAGE_EXISTANCE);
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(ERROR);
                    continue;
                }
                continueProgram = false;
            }
        }
    }
}

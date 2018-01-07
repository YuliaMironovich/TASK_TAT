using System;

namespace ComplexNumberTask
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber1 = new ComplexNumber(double.MaxValue - 1, double.MaxValue - 1);
            ComplexNumber complexNumber2 = new ComplexNumber(5 , 5);
            ComplexNumber complexNumber = complexNumber1 + complexNumber2;
            int ten = 10;
            Console.WriteLine(2147483647 + ten);
            
            Console.ReadKey();
        }
    }
}
 
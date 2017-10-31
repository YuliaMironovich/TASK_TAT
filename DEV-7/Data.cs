using System;

namespace DEV_7
{
    public class Data
    {
        private const string ENTER_MESSAGE = "\n Enter throught the 'Enter' dimenshions of the sides of the triangle: ";
        public Sides Input (Sides sides)
        {
            Console.WriteLine(ENTER_MESSAGE);
            sides.aSide = double.Parse(Console.ReadLine());
            sides.bSide = double.Parse(Console.ReadLine());
            sides.cSide = double.Parse(Console.ReadLine());
            return sides;
        }
    }
}

using System;

namespace DEV_7
{
    public class CommonTriangle : Triangle
    {
        private double a, b, c;
        public CommonTriangle (double aSide, double bSide, double cSide)
        {
            a = aSide;
            b = bSide;
            c = cSide;
        }
        public override string GetType()
        {
            return "Common triangle";
        }
    }
}

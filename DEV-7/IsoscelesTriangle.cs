namespace DEV_7
{
    public class IsoscelesTriangle : Triangle
    {
        private double a, b, c;
        public IsoscelesTriangle(double aSide, double bSide, double cSide)
        {
            a = aSide;
            b = bSide;
            c = cSide;
        }
        public override string GetType()
        {
            return "Isosceles triangle";
        }
    }
}

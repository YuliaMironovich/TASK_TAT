namespace DEV_7
{
    public  class EquilateralTriangle : Triangle
    {
        private double a, b, c;
        public EquilateralTriangle (double aSide, double bSide, double cSide):base()
        {
            a = aSide;
            b = bSide;
            c = cSide;
        }
        public override string GetType()
        {
            return "Equilateral triangle";
        }
    }
}

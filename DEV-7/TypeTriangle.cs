namespace DEV_7
{
    public class TypeTriangle
    {
        public enum Types
        {
            Common,
            Isosceles,
            Equilateral
        };
        public Types Determine(Sides sides)
        {
            if ((sides.aSide == sides.bSide) && (sides.aSide == sides.cSide))
            {
                return Types.Equilateral;
            }
            if ((sides.aSide == sides.bSide) || (sides.bSide == sides.cSide) || (sides.aSide == sides.cSide))
            {
                return Types.Isosceles;
            }
            else
            {
                return Types.Common;
            }
        }
    }
}

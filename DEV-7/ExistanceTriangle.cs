using System;

namespace DEV_7
{
    public class ExistanceTriangle
    {
        private double epsilon = Math.Pow(10, -6);
        public bool IfExistance(Sides sides)
        {
            if (CheckSide(sides) && CheckCondition(sides))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckSide(Sides sides)
        {
            if ((sides.aSide > epsilon) && (sides.bSide > epsilon) && (sides.cSide > epsilon))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckCondition(Sides sides)
        {
            if ((sides.aSide + sides.bSide - sides.cSide < epsilon) || (sides.aSide + sides.cSide - sides.bSide < epsilon) || (sides.bSide + sides.cSide - sides.aSide < epsilon))
            {
                return false;
            }
            return true;
        }
    }
}

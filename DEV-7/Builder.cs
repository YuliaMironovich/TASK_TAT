using System;

namespace DEV_7
{
    public class Builder
    {
        public Triangle BuildTriangle (TypeTriangle.Types type, Sides sides)
        {
            switch (type)
            {
                case TypeTriangle.Types.Isosceles:
                    return new IsoscelesTriangle(sides.aSide, sides.bSide, sides.cSide);
                    break; 
                case TypeTriangle.Types.Equilateral:
                    return new EquilateralTriangle(sides.aSide, sides.bSide, sides.cSide);
                    break;
                default:
                    return new CommonTriangle(sides.aSide, sides.bSide, sides.cSide);
                    break;
            }
            
        }
    }
}

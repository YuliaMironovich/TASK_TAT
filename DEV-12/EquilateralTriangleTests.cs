using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_7.Test
{
    [TestClass]
    public class EquilateralTriangleTests
    {
        [TestMethod]
        public void getTypeWithEqualsSidesEquilateralTriangleReturned()
        {
            Triangle equilateralTriangle = new EquilateralTriangle(2,2,2);
            Sides side = new Sides();
            side.aSide = 2;
            side.bSide = 2;
            side.cSide = 2;
            TypeTriangle typeTriangle = new TypeTriangle();
            TypeTriangle.Types type = typeTriangle.Determine(side);
            Builder builder = new Builder();
            Triangle triangle = builder.BuildTriangle(type, side);
            Assert.AreEqual(equilateralTriangle.GetType(), triangle.GetType());
        }
    }
}

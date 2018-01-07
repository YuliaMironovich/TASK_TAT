using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_7.Test
{
    [TestClass]
    public class IsoscelesTriangleTests
    {
        [TestMethod]
        public void getTypeWithTwoEqualsSidesIsoscelesTriangleReturned()
        {
            Triangle isoscelesTriangle = new IsoscelesTriangle(2, 2, 3);
            Sides side = new Sides();
            side.aSide = 2;
            side.bSide = 2;
            side.cSide = 3;
            TypeTriangle typeTriangle = new TypeTriangle();
            TypeTriangle.Types type = typeTriangle.Determine(side);
            Builder builder = new Builder();
            Triangle triangle = builder.BuildTriangle(type, side);
            Assert.AreEqual(isoscelesTriangle.GetType(), triangle.GetType());
        }
    }
}

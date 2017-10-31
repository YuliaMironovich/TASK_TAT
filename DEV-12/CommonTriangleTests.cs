using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_7.Test
{
    [TestClass]
    public class CommonTriangleTests
    {
        [TestMethod]
        public void getTypeWithDifferentSidesCommonTriangleReturned()
        {
            Triangle commonTriangle = new CommonTriangle(3, 4, 5);
            Sides side = new Sides();
            side.aSide = 3;
            side.bSide = 4;
            side.cSide = 5;
            TypeTriangle typeTriangle = new TypeTriangle();
            TypeTriangle.Types type = typeTriangle.Determine(side);
            Builder builder = new Builder();
            Triangle triangle = builder.BuildTriangle(type, side);
            Assert.AreEqual(commonTriangle.GetType(), triangle.GetType());  
        }
    }
}

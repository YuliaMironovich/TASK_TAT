using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1_task4.Test
{
    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void SetCorrectCoordinatePositive()
        {
            Assert.AreEqual('A', new Coordinate('A', 2).X);
        }

        [TestMethod]
        public void SetCorrectSecondCoordinatePositive()
        {
            Assert.AreEqual(2, new Coordinate('A', 2).Y);
        }

        [TestMethod]
        public void SetCorrectCoordinateWithRegisterPositive()
        {
            Assert.AreEqual('A', new Coordinate('A', 2).X);
        }


        [TestMethod]
        public void SetIncorrectFirstCoordinateNegative()
        {
            Assert.AreEqual('\0', new Coordinate('N', 2).X);
        }

        [TestMethod]
        public void SetIncorrectSecondCoordinateNegative()
        {
            Assert.AreEqual(0, new Coordinate('A', 11).Y);
        }
    }
}

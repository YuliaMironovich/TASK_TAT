using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DEV_7.Test
{
    [TestClass]
    public class ExistanceTriangleTests
    {
        [TestMethod]
        public void checkSideWithNullValueSidesReturnedFalse()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = Math.Pow(10, -6);
            sides.bSide = 1;
            sides.cSide = 2;
            Assert.IsFalse(existanceTriangle.CheckSide(sides));
        }

        [TestMethod]
        public void checkSideWithNegativeValueSidesReturnedFalse()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = -5;
            sides.bSide = -10;
            sides.cSide = 7;
            Assert.IsFalse(existanceTriangle.CheckSide(sides));
        }

        [TestMethod]
        public void checkSideWithSymbolValueSidesReturnedFalse()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = 'a';
            sides.bSide = 1;
            sides.cSide = 2;
            Assert.IsFalse(existanceTriangle.CheckSide(sides));
        }

        [TestMethod]
        public void checkSideWithMaxValueSidesReturnedFalse()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = Math.Pow(10,320);
            sides.bSide = Math.Pow(10, 320);
            sides.cSide = Math.Pow(10, 320);
            Assert.IsFalse(existanceTriangle.CheckSide(sides));
        }

        [TestMethod]
        public void checkConditionWithCorrectValuesOfSideReturnedTrue()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = 3.005;
            sides.bSide = 4.95;
            sides.cSide = 6.35001;
            Assert.IsTrue(existanceTriangle.CheckCondition(sides));
        }

        [TestMethod]
        public void checkConditionWithIncorrectValuesOfSideReturnedFalse()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = 1;
            sides.bSide = 2;
            sides.cSide = 10;
            Assert.IsFalse(existanceTriangle.CheckCondition(sides));
        }

        [TestMethod]
        public void checkConditionWithCloserValuesOfSideReturnedTrue()
        {
            ExistanceTriangle existanceTriangle = new ExistanceTriangle();
            Sides sides = new Sides();
            sides.aSide = 1.000001;
            sides.bSide = 1;
            sides.cSide = 1.505;
            Assert.IsTrue(existanceTriangle.CheckCondition(sides));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_13.Test
{
    [TestClass]
    public class CheckerOfConditionTests
    {
        //TestMethod checks Method IfCorrectCash which returns true 
        //if the value of cash is greater than the junior salary
        [TestMethod]
        public void IfCorrectCashWithValueBiggerThanSalaryOfJuniorReturnedTrue()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = 1000;
            Assert.IsTrue(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns true 
        //if the value of cash is equal the junior salary
        [TestMethod]
        public void IfCorrectCashWithValueEqualSalaryOfJuniorReturnedTrue()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = 500;
            Assert.IsTrue(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false 
        //if the value of cash is less than the junior salary
        [TestMethod]
        public void IfCorrectCashWithLessThanSalaryOfJuniorReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = 300;
            Assert.IsFalse(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false
        //if the value of cash is null 
        [TestMethod]
        public void IfCorrectCashWithNullVallueJuniorReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = 0;
            Assert.IsFalse(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false
        //if the value of cash is negative
        [TestMethod]
        public void IfCorrectCashWithNegativeValueReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = -5;
            Assert.IsFalse(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false
        //if the value of cash is Maximum of Int32
        [TestMethod]
        public void IfCorrectCashWithValueMaxThanIntReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.cash = Int32.MaxValue;
            Assert.IsFalse(checkerOfCondition.IfCorrectCash(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns true 
        //if the value of productivity is greater than null
        [TestMethod]
        public void IfCorrectProductivityWithValueBiggerThanNullReturnedTrue()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.productivity = 1000;
            Assert.IsTrue(checkerOfCondition.IfCorrectProductivity(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns true 
        //if the value of cash is null
        [TestMethod]
        public void IfCorrectProductivityWithNullValueReturnedTrue()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.productivity = 0;
            Assert.IsTrue(checkerOfCondition.IfCorrectProductivity(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false 
        //if the value of cash is negative
        public void IfCorrectProductivityWithNegativeValueReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.productivity = -5;
            Assert.IsFalse(checkerOfCondition.IfCorrectProductivity(initialCondition));
        }

        //TestMethod checks Method IfCorrectCash which returns false 
        //if the value of cash is Maximum Int32
        public void IfCorrectProductivityWithMaxIntValueReturnedFalse()
        {
            CheckerOfCondition checkerOfCondition = new CheckerOfCondition();
            InitialCondition initialCondition = new InitialCondition();
            initialCondition.productivity = Int32.MaxValue;
            Assert.IsFalse(checkerOfCondition.IfCorrectProductivity(initialCondition));
        }
    }
}

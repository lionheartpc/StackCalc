using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator.Tests
{
    [TestClass()]
    public class StackCalculatorTests
    {
        [TestMethod()]
        public void getStackStringTest_IsEmpty()
        {
            //Arrange
            StackCalculator<int> testObject = new StackCalculator<int>();
            string ExpectedResult = "";
            //Act Assert
            Assert.IsTrue(testObject.GetStackString() == ExpectedResult);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void pushTest_MaxCapacity()
        {
            //Arrange
            StackCalculator<int> testObject = new StackCalculator<int>();
            //Act
            testObject.Push(1);
            testObject.Push(2);
            testObject.Push(3);
            testObject.Push(4);
            testObject.Push(5);
            testObject.Push(6);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CaclulatorTests
    {
        [TestMethod]
        public void Add_Sums_FirstNumber_And_SecondNumber()
        {
            //Arrange
            var num1 = 1;
            var num2 = 2;
            var expect = num1 + num2;
            var calc = new Calculator();
            calc.FirstNumber = num1;
            calc.SecondNumber = num2;

            //Act
            var result = calc.Add();

            //Assert
            Assert.AreEqual(expect, result);
        }
    }
}

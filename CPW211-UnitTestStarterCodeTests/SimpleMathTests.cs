using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [TestCategory("Add")]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double sum = num1 + num2;
            Assert.AreEqual(sum, SimpleMath.Add(num1, num2));
        }



        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [TestCategory("Subtract")]
        [DataRow(5, 10)]
        [DataRow(10,5)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double difference = num1 - num2;
            Assert.AreEqual(difference, SimpleMath.Subtract(num1, num2));
        }



        [TestMethod]
        [TestCategory("Multiply")]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            Assert.Fail();
        }



        [TestMethod]
        [TestCategory("Divide")]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.Fail();
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod()]
        [TestCategory("Divide")]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            Assert.Fail();
        }
    }
}
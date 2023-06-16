using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testing_Code;

namespace TestingCode
{
    [TestClass]
    public class CalculatorTestCode
    {
        [TestMethod]
        public void Given_TwoNumbers_Should_Return_Sum()
        {

            int x = 40;
            int y = 30;
            int expected = 70;
            Calculator calculator = new Calculator();

            int actual = calculator.AddTwoNumbers(x, y);


            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Given_TwoNumbers_Should_Return_Sub()
        {
            Calculator cal = new Calculator();
            int res = cal.SubTwoNumbers(40, 30);
            Assert.AreEqual(10, res);


        }
        [TestMethod]
        public void Given_TwoNumbers_Should_Return_Multi()
        {
            Calculator mul = new Calculator();
            int res = mul.MultiTwoNumbers(10, 30);
            Assert.AreEqual(300, res);

        }










}   }

    

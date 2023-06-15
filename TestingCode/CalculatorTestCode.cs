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

            int actual=calculator.AddTwoNumers(x, y);


            Assert.AreEqual(expected, actual);  
            
        }
        //[TestMethod]
        //public void Given_TwoNumbers_Should_Return_Sub()
        //{
        //    int x = 40;
        //    int y = 30;
        //    int expected = 10;
        //    Calculator calculator = new Calculator();

        //    int actual = Calculator.S
        //    }
    }
    }

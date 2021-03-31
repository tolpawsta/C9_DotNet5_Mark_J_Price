using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CalculatorLib;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And3()
        {
            //arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();

            // act
            double actual = calc.Add(a, b);

            // assert
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void TestAddingMinus1And1()
        {
            // arrange
            double a = -1;
            double b = 1;
            double expected = 0;
            var calc = new Calculator();

            // act
            var actual = calc.Add(a, b);

            // assert
            Assert.Equal (expected, actual);
        }
    }
}

using System.Runtime.CompilerServices;
using System;
using PrimeFactorsLib;
using Xunit;

namespace PrimeCalculatorUnitTests
{
    public class PrimeCalculatorTests
    {
        [Fact]
        public void PrimeFactorsFromNunber4()
        {
            // arrange
            var number = 4;
            var expected = "2*2";
            var calc = new PrimeCalculator();

            // act
            var actual = calc.PrimeFactors(number);

            // assert
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void PrimeFactorsFromNumber7()
        {
            // arrange
            var number = 7;
            var expected = "7";
            var calc = new PrimeCalculator();

            // act
            var actual = calc.PrimeFactors(number);

            // assert
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void PrimeFactorsFromNumber30()
        {
            // arrange
            var number = 30;
            var expected = "2*3*5";
            var calc = new PrimeCalculator();

            // act
            var actual = calc.PrimeFactors(number);

            // asssert
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void PrimeFactorsFromNumber1001()
        {
            // arrange
            var number = 1001;
            var calc=new PrimeCalculator();

            // act
            Action act=()=>calc.PrimeFactors(number);
            
            // assert
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void PrimeFactorsFromNumber40()
        {
            // arrange
            var number = 40;
            var calc = new PrimeCalculator();
            var expected = "2*2*2*5";
            // act
            var actual = calc.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}

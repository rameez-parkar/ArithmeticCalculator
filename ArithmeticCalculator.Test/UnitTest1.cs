using ArithmeticCalculator.App;
using System;
using Xunit;

namespace ArithmeticCalculator.Test
{
    public class ArithemticCalculatorTest
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void AdditionTest()
        {
            var addition = calculator.SetOperation("add");
            addition.AcceptOperands(4.6, 5.1);

            var expected = 9.7;
            var actual = addition.PerformCalculation();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void SubtractionTest()
        {
            var subtraction = calculator.SetOperation("subtract");
            subtraction.AcceptOperands(9.6, 2.5);

            var expected = 7.1;
            var actual = subtraction.PerformCalculation();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void MultiplicationTest()
        {
            var multiplication = calculator.SetOperation("multiply");
            multiplication.AcceptOperands(9.0, 2.5);

            var expected = 22.5;
            var actual = multiplication.PerformCalculation();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void DivisionTest()
        {
            var division = calculator.SetOperation("divide");
            division.AcceptOperands(9.0, 3.0);

            var expected = 3.0;
            var actual = division.PerformCalculation();

            Assert.Equal(expected, actual, 2);
        }
    }
}

using NUnit.Framework;
using System;

namespace Kalkulator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(-10, 5, -5)]
        [TestCase(-20, -10, -30)]
        public void Add_TwoValidArguments_ReturnSum(double a, double b, double expected)
        {
            double result = Calculator.Add(a, b);
            Assert.That(Is.Equals(result, expected));
        }

        [Test]
        [TestCase(2, 2, 0)]
        [TestCase(-10, 5, -15)]
        [TestCase(-20, -10, -10)]
        public void Substract_TwoValidArguments_ReturnSubstraction(double a, double b, double expected)
        {
            double result = Calculator.Substract(a, b);
            Assert.That(Is.Equals(result, expected));
        }

        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(-10, 5, -50)]
        [TestCase(-20, -10, 200)]
        public void Multiply_TwoValidArguments_ReturnMultiplication(double a, double b, double expected)
        {
            double result = Calculator.Multiply(a, b);
            Assert.That(Is.Equals(result, expected));
        }

        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(-10, 5, -2)]
        [TestCase(-20, -10, 2)]
        [TestCase(0, 10, 0)]
        public void Divide_TwoValidArguments_ReturnDivision(double a, double b, double expected)
        {
            double result = Calculator.Divide(a, b);
            Assert.That(Is.Equals(result, expected));
        }

        [Test]
        public void Divide_DivideByZero_ThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(10, 0));
        }
    }
}
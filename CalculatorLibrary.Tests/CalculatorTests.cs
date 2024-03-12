// CalculatorTests.cs
using Xunit;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Add(2, 3));
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            Assert.Equal(2, calculator.Subtract(5, 3));
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            Assert.Equal(15, calculator.Multiply(5, 3));
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            Assert.Equal(2, calculator.Divide(10, 5));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
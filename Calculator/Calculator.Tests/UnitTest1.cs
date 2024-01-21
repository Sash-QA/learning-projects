using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Sum5and3_8expected()
        {
            // Arrange
            double firstNum = 5;
            double secondNum = 3;

            // Act
            double result = Calculator.Add(firstNum, secondNum);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Sub5and3_2expected()
        {
            // Arrange
            double firstNum = 5;
            double secondNum = 3;

            // Act
            double result = Calculator.Subtract(firstNum, secondNum);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Mult5and3_15expected()
        {
            // Arrange
            double firstNum = 5;
            double secondNum = 3;

            // Act
            double result = Calculator.Multiply(firstNum, secondNum);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Div6and3_2expected()
        {
            // Arrange
            double firstNum = 6;
            double secondNum = 3;

            // Act
            double result = Calculator.Divide(firstNum, secondNum);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void DivBy0_ExpectedException()
        {
            // Arrange
            double firstNum = 6;
            double secondNum = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Calculator.Divide(firstNum, secondNum));
        }
    }
}

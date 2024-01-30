namespace Calculator.Tests
{
    [TestFixture]                                   // Указывает на то, что класс содержит тесты
    public class CalculatorTests
    {
        [Test]                                                  
        public void Sum5and3_8expected()            // Тест на сложение
        {
            // Arrange (создание переменных)
            double firstNum = 5;
            double secondNum = 3;

            // Act (вызов метода из тестируемого кода)
            double result = Calculator.Add(firstNum, secondNum);

            // Assert (проверка, что результат соответствует указанному)
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Sub5and3_2expected()            // Тест на вычитание
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
        public void Mult5and3_15expected()          // Тест на умножение
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
        public void Div6and3_2expected()            // Тест на деление
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
        public void DivBy0_ExpectedException()      // Тест на деление на ноль
        {
            // Arrange
            double firstNum = 6;
            double secondNum = 0;

            // Act & Assert (объединены, так как 'Assert.Throws' имеет особенности выполнения проверки)
            Assert.Throws<ArgumentException>(() => Calculator.Divide(firstNum, secondNum));
        }
    }
}

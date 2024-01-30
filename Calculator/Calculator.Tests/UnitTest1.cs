namespace Calculator.Tests
{
    [TestFixture]                                   // Óêàçûâàåò íà òî, ÷òî êëàññ ñîäåðæèò òåñòû
    public class CalculatorTests
    {
        [Test]                                                  
        public void Sum5and3_8expected()            // Òåñò íà ñëîæåíèå
        {
            // Arrange (ñîçäàíèå ïåðåìåííûõ)
            double firstNum = 5;
            double secondNum = 3;

            // Act (âûçîâ ìåòîäà èç òåñòèðóåìîãî êîäà)
            double result = Calculator.Add(firstNum, secondNum);

            // Assert (ïðîâåðêà, ÷òî ðåçóëüòàò ñîîòâåòñòâóåò óêàçàííîìó)
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Sub5and3_2expected()            // Òåñò íà âû÷èòàíèå
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
        public void Mult5and3_15expected()          // Òåñò íà óìíîæåíèå
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
        public void Div6and3_2expected()            // Òåñò íà äåëåíèå
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
        public void DivBy0_ExpectedException()      // Òåñò íà äåëåíèå íà íîëü
        {
            // Arrange
            double firstNum = 6;
            double secondNum = 0;

            // Act & Assert (îáúåäèíåíû, òàê êàê 'Assert.Throws' èìååò îñîáåííîñòè âûïîëíåíèÿ ïðîâåðêè)
            Assert.Throws<ArgumentException>(() => Calculator.Divide(firstNum, secondNum));
        }
    }
}

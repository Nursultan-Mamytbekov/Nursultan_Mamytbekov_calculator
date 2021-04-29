using Calculator.CalculatorCreators;
using Calculator.Calculators;

using Xunit;

namespace CalculatorTests
{
    public class CalculateTests
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            var calculator = new ConsoleCalculatorCreator().CreateCalculator();

            //Act
            var expected = 6;
            var result = calculator.Calculate(2, 4, Operation.Add);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractTest()
        {
            //Arrange
            var calculator = new ConsoleCalculatorCreator().CreateCalculator();

            //Act
            var expected = 3;
            var result = calculator.Calculate(7, 4, Operation.Subtract);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MultiplyTest()
        {
            //Arrange
            var calculator = new ConsoleCalculatorCreator().CreateCalculator();

            //Act
            var expected = 9;
            var result = calculator.Calculate(3, 3, Operation.Multiply);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideTest()
        {
            //Arrange
            var calculator = new ConsoleCalculatorCreator().CreateCalculator();

            //Act
            var expected = 4;
            var result = calculator.Calculate(12, 3, Operation.Divide);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NotCalculatedTest()
        {
            //Arrange
            var calculator = new ConsoleCalculatorCreator().CreateCalculator();

            //Assert
            Assert.Null(calculator.Result);
            Assert.Null(calculator.FirstValue);
            Assert.Null(calculator.SecondValue);
        }
    }
}

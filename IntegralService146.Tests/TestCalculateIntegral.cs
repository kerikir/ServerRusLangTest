using IntegralService146.Calculators;

namespace IntegralService146.Tests
{
    public class TestCalculateIntegral
    {
        [Fact]
        public void CalculateRectangle_X_X_X_CorrectResult()
        {
            // Arrange
            CalculatorRect calculator = new CalculatorRect();
            double correctResult = 1.265625;

            // Act
            double result = calculator.Calculate(0.0, 1.5, 10000, x => x * x * x);

            // Assert
            Assert.Equal(correctResult, result, 4);
        }


        [Fact]
        public void CalculateRectangle_ConstantFunction_CorrectResult()
        {
            // Arrange
            CalculatorRect calculator = new CalculatorRect();
            Func<double, double> func = x => 2.0;

            // Act
            double result = calculator.Calculate(0.0, 100.0, 1000, func);

            // Assert
            Assert.Equal(200, result, 4);
        }
        

        [Fact]
        public void CalculateRectangle_NegativeSteps_ArgumentException()
        {
            // Arrange
            CalculatorRect calculator = new CalculatorRect();
            double xStart = 0.0;
            double xEnd = 100.0;
            int steps = -100000;
            Func<double, double> func = x => x * x;

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => calculator.Calculate(xStart, xEnd, steps, func));
        }


        [Fact]
        public void Calculate_SwapBorder_CorrectResult()
        {
            // Arrange
            var calculator = new CalculatorRect();

            // Act
            double resultFirst = calculator.Calculate(0.0, 1.0, 1000, x => x * x * x);
            double resultSecond = calculator.Calculate(1.0, 0.0, 1000, x => x * x * x);

            // Assert
            Assert.Equal(resultFirst, -resultSecond, 4);
        }


        [Fact]
        public void Calculate_NegativeBorder_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new CalculatorRect();

            // Act
            double result = calculator.Calculate(-5.0, -2.0, 10000, x => x * x * x);

            // Assert
            Assert.Equal(-152.25, result, 4);
        }
    }
}
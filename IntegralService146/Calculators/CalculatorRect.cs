using System.Diagnostics.Metrics;

namespace IntegralService146.Calculators
{
    public class CalculatorRect : ICalculator
    {
        public double Calculate(double down, double up, int numIntaration, Func<double, double> subInterral)
        {
            //проверка на некорректное число шагов
            if (numIntaration < 0)
            {
                throw new ArgumentException("Incorrect number of steps");
            }

            double sum = 0.0;
            double h = (up - down) / numIntaration;

            for (int i = 1; i <= numIntaration; i++)
            {
                sum += subInterral(down + h * i - 0.5 * h);
            }

            

            return h * sum;
        }
    }
}

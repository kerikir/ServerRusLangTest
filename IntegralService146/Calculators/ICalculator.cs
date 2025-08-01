namespace IntegralService146.Calculators
{
    public interface ICalculator
    {
        public double Calculate(double down, double up, int numIntaration, Func<double, double> subInterral);
    }
}

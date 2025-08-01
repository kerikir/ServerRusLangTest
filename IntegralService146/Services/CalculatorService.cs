using IntegralService146.Calculators;
using IntegralService146.Models;
using MathNet.Symbolics;
using System.Security.Cryptography.X509Certificates;

namespace IntegralService146.Services
{
    public class CalculatorService : ICalculatorService
    {
        public IntegralOutputData Calculate(IntegralInputData input)
        {
            Func<double, double> f = SymbolicExpression.Parse(input.FuncIntegral).Compile("x");
            ICalculator calculatorRect = new CalculatorRect();
            IntegralOutputData integralOutputData = new IntegralOutputData();
            integralOutputData.Result = calculatorRect.Calculate(input.DownLimit, input.UpLimit, input.N, f);
            return integralOutputData;
        }
    }
}

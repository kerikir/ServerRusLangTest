using IntegralService146.Models;
namespace IntegralService146.Services
{
    public interface ICalculatorService
    {
        public IntegralOutputData Calculate(IntegralInputData Input);
    }
}

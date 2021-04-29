using Calculator.Calculators;

namespace Calculator.CalculatorCreators
{
    public interface ICalculatorCreator
    {
        public ICalculator CreateCalculator();
    }
}

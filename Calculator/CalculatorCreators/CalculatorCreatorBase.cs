using Calculator.Calculators;

namespace Calculator.CalculatorCreators
{
    public abstract class CalculatorCreatorBase : ICalculatorCreator
    {
        public abstract ICalculator CreateCalculator();
    }
}

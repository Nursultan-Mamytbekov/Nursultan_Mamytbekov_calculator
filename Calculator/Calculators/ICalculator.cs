namespace Calculator.Calculators
{
    public interface ICalculator
    {
        public double? FirstValue { get; }
        public double? SecondValue { get; }
        public double? Result { get; }
        public double? Calculate(double firstValue, double secondValue, Operation operation);
        public void ShowResult();
    }
}

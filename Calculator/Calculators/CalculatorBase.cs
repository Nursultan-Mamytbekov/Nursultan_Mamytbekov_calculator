using System;

namespace Calculator.Calculators
{
    public abstract class CalculatorBase : ICalculator
    {
        public double? FirstValue { get; private set; }

        public double? SecondValue { get; private set; }

        public double? Result { get; private set; }

        public CalculatorBase()
        {
            FirstValue = null;
            SecondValue = null;
            Result = null;
        }

        public double? Calculate(double firstValue, double secondValue, Operation operation)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            switch (operation)
            {
                case Operation.Add: return Result = FirstValue + SecondValue;
                case Operation.Subtract: return Result = FirstValue - SecondValue;
                case Operation.Multiply: return Result = FirstValue * SecondValue;
                case Operation.Divide:
                    if (FirstValue == 0) throw new DivideByZeroException("cannot be divisible by 0");
                    return Result = FirstValue / SecondValue;
            }
            throw new ArgumentException("operation selected incorrectly");
        }

        public abstract void ShowResult();
    }
}


      

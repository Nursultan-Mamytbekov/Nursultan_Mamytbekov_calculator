using System;

namespace Calculator.Calculators
{
    public class ConsoleCalculator : CalculatorBase
    {        
        public override void ShowResult()
        {
            Console.WriteLine($"Result is {Result}");
        }
    }
}

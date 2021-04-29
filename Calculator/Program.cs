using Calculator.CalculatorCreators;
using Calculator.Calculators;

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            byte choose;
            while (true)
            {
                Console.WriteLine("enter the first value");
                var firstValueInput = Console.ReadLine();

                if (!double.TryParse(firstValueInput, out firstValue)) break;
                
                Console.WriteLine("enter the second value");
                var secondValueInput = Console.ReadLine();
                
                if (!double.TryParse(secondValueInput, out secondValue)) break;
                
                Console.WriteLine(
                    "choose th operation:\n" +
                    "0 - add\n" +
                    "1 - subtract\n" +
                    "2 - multiply\n" +
                    "3 - divide\n" 
                );
                var chooseInput = Console.ReadLine();
                
                if (!byte.TryParse(chooseInput, out choose)) break;
                
                var calculator = new ConsoleCalculatorCreator().CreateCalculator();
                var op = (Operation)choose;
                try
                {
                    calculator.Calculate(firstValue, secondValue, op);
                    calculator.ShowResult();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
        }
    }
}

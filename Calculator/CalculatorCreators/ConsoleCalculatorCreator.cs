using Calculator.Calculators;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CalculatorCreators
{
    public class ConsoleCalculatorCreator : CalculatorCreatorBase
    {
        public override ICalculator CreateCalculator()
        {
            return new ConsoleCalculator();
        }
    }
}

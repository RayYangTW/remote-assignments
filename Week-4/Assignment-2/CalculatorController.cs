using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_2
{
  public class CalculatorController
  {
    private readonly ICalculator _calculator;
    private readonly string calculatorType;

    public CalculatorController(ICalculator _calculator, string calculatorType)
    {
      this._calculator = _calculator;
      this.calculatorType = calculatorType;
    }

    public int Calculate(int a, int b)
    {
      if (calculatorType == "Add")
      {
        return _calculator.Add(a, b);
      }
      else if (calculatorType == "Subtract")
      {
        return _calculator.Subtract(a, b);
      }
      else
      {
        throw new Exception("Wrong type.");
      }
    }
  }
}
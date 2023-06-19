using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_2
{
  public interface ICalculator
  {
    int Add(int a, int b);
    int Subtract(int a, int b);
  }

  public class SimpleCalculator : ICalculator
  {
    public int Add(int a, int b)
    {
      return a + b;
    }

    public int Subtract(int a, int b)
    {
      return a - b;
    }
  }

  public class AdvancedCalculator : ICalculator
  {
    public int Add(int a, int b)
    {
      return (a + b) * 100 / 100;
    }

    public int Subtract(int a, int b)
    {
      return (a - b) * 100 / 100;
    }
  }
}
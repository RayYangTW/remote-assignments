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
      while (b != 0)
      {
        int carry = a & b; // 計算進位
        a = a ^ b; // 不進位相加
        b = carry << 1; // 左移進位
      }
      return a;
    }

    public int Subtract(int a, int b)
    {
      while (b != 0)
      {
        int borrow = (~a) & b; // 計算借位
        a = a ^ b; // 不借位相減
        b = borrow << 1; // 左移借位
      }
      return a;
    }
  }
}
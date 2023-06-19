using Microsoft.Extensions.DependencyInjection;

namespace Assignment_2
{
  public class Program
  {
    static void Main(string[] args)
    {

      var serviceProvider = new ServiceCollection()
        .AddTransient<ICalculator, SimpleCalculator>()
        .AddTransient<CalculatorController>()
        .AddSingleton<string>("Add")
        .BuildServiceProvider();

      var calculatorController = serviceProvider.GetService<CalculatorController>();

      Console.WriteLine($"{calculatorController?.Calculate(59, 60)}");

    }
  }
}




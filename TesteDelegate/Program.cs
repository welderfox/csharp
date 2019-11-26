using System;

namespace TesteDelegate
{
  delegate double BinaryNumericOperation(double n1, double n2);
  class Program
  {
    class CalculationService
    {
      public static double Max(double x, double y)
      {
        return (x > y) ? x : y;
      }
      public static double Sum(double x, double y)
      {
        return x + y;
      }
      public static double Square(double x)
      {
        return x * x;
      }
    }
    static void Main(string[] args)
    {
      double a = 10;
      double b = 12;

      BinaryNumericOperation op = CalculationService.Sum;

      double result = op(a, b);
      Console.WriteLine(result);
    }
  }
}
